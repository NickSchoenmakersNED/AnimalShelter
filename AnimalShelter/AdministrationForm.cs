using AnimalShelter.Classes;
using AnimalShelter.Data;
using AnimalShelter.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        private AnimalShelterDbContext context = new AnimalShelterDbContext();
        private Administration admin;

        private ToolTip toolTip = new ToolTip();

        private readonly string filePathToLocations = Path.Combine(AppContext.BaseDirectory, "Locations.json");

        // https://stackoverflow.com/questions/670566/path-combine-absolute-with-relative-path-strings
        // https://stackoverflow.com/questions/6041332/best-way-to-get-application-folder-path

        public AdministrationForm()
        {
            InitializeComponent();
            CmbAnimalType.SelectedIndex = 0;

            context.Database.EnsureCreated();
            admin = new Administration(context);
            RefreshListboxes();

            List<Location> locations = admin.LoadLocations();

            LbxLocations.DataSource = locations;
            LbxLocations.DisplayMember = "Name"; 
            LbxLocations.ValueMember = "ID";


            CmdSpecialField1.DataSource = context.Animals
                .OfType<Horse>()
                .Where(h => !h.IsReserved)
                .Select(h => h.Type)
                .Distinct()
                .ToList();
        }

        private void RefreshListboxes()
        {
            LbxAnimalsNotReserved.DataSource = null;
            LbxAnimalsReserved.DataSource = null;

            LbxAnimalsNotReserved.DataSource = context.Animals
                .Include(a => (a as Horse).Type)
                .Where(a => !a.IsReserved)
                .ToList();

            LbxAnimalsReserved.DataSource = context.Animals
                .Include(a => (a as Horse).Type)
                .Where(a => a.IsReserved)
                .ToList();

            LbxAnimalsNotReserved.DisplayMember = nameof(Animal.ToString);
            LbxAnimalsReserved.DisplayMember = nameof(Animal.ToString);
        }

        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            string animalType = CmbAnimalType.SelectedItem.ToString().ToLower();
            string name = TxbAnimalName.Text;

            string[] splitDate = TxbDateOfBirth.Text.Split('-');
            SimpleDate dateOfBirth = null;

            if (string.IsNullOrWhiteSpace(TxbDateOfBirth.Text))
            {
                var result = MessageBox.Show(
                    "No date of birth provided. Are you sure you want to continue without it?",
                    "Missing Date of Birth",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No) 
                {
                    return;
                }
            }
            else
            {
                if (splitDate.Length == 3 &&
                    int.TryParse(splitDate[0], out int day) &&
                    int.TryParse(splitDate[1], out int month) &&
                    int.TryParse(splitDate[2], out int year))
                {
                    try
                    {
                        dateOfBirth = new SimpleDate(day, month, year);
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        MessageBox.Show("One or more date values are out of range. Please ensure the day, month, and or year are valid numbers.");
                        return;
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show($"Invalid date: {ex.Message}");
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Date format is invalid. Please use the format DD-MM-YYYY.");
                    return;
                }
            }

            Animal newAnimal = null;

            switch (animalType)
            {
                case "dog":
                    string[] parts = TxbSpecialField1.Text.Split('-');
                    SimpleDate lastWalk;

                    try
                    {
                        lastWalk = new SimpleDate(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]));
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        MessageBox.Show("One or more date values are out of range. Please ensure the day, month, and year are valid numbers.");
                        return;
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show($"Invalid date: {ex.Message}");
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                        return;
                    }
                    string input = TxbSpecialField2.Text.ToLower();

                    bool isGuideDog;
                    if (input == "yes" || input == "true")
                    {
                        isGuideDog = true;
                    }
                    else
                    {
                        isGuideDog = false;
                    }
                    Dog dog = new Dog(dateOfBirth, name, lastWalk)
                    {
                        GuideDog = isGuideDog
                    };
                    newAnimal = dog;
                    break;

                case "cat":
                    newAnimal = new Cat(dateOfBirth, name, TxbSpecialField1.Text);
                    break;

                case "horse":
                    if (CmdSpecialField1.SelectedItem is HorseType selectedType)
                    {
                        newAnimal = new Horse(dateOfBirth, name, selectedType);
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid horse type.");
                        return;
                    }
                    break;

                case "lizard":
                    string climate = TxbSpecialField1.Text;
                    string species = TxbSpecialField2.Text;
                    newAnimal = new Lizard(dateOfBirth, name, climate, species);
                    break;

                case "parrot":
                    bool canTalk;
                    input = TxbSpecialField1.Text.ToLower();

                    if (input == "yes" || input == "true")
                    {
                        canTalk = true;
                    }
                    else
                    {
                        canTalk = false;
                    }
                    newAnimal = new Parrot(dateOfBirth, name, canTalk);
                    break;

                default:
                    MessageBox.Show("Invalid animal type selected.");
                    return;
            }

            admin.AddAnimal(newAnimal);
            context.SaveChanges();
            RefreshListboxes();
        }

        private void BtnDeleteAnimal_Click(object sender, EventArgs e)
        {
            var selected = LbxAnimalsNotReserved.SelectedItems.Cast<Animal>()
                .Concat(LbxAnimalsReserved.SelectedItems.Cast<Animal>())
                .ToList();

            foreach (var animal in selected)
            {
                admin.RemoveAnimal(animal.Id);
            }

            context.SaveChanges();
            RefreshListboxes();
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            foreach (Animal selected in LbxAnimalsNotReserved.SelectedItems)
            {
                var tracked = context.Animals.FirstOrDefault(a => a.Id == selected.Id);
                if (tracked != null) tracked.IsReserved = true;
            }

            context.SaveChanges();
            RefreshListboxes();
        }

        private void BtnReserveCancel_Click(object sender, EventArgs e)
        {
            foreach (Animal selected in LbxAnimalsReserved.SelectedItems)
            {
                var tracked = admin.FindAnimal(selected.Id);
                if (tracked != null) tracked.IsReserved = false;
            }

            context.SaveChanges();
            RefreshListboxes();
        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            var animal = LbxAnimalsNotReserved.SelectedItem as Animal;

            if (animal != null)
            {
                MessageBox.Show(animal.ToString());
            }
            else
            {
                animal = LbxAnimalsReserved.SelectedItem as Animal;
                MessageBox.Show(animal.ToString());
            }
        }

        private void CmbAnimalType_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (CmbAnimalType.Text)
            {
                case "Dog":
                    LblSpecialField1.Text = "Last walked";
                    TxbSpecialField1.Visible = true;
                    CmdSpecialField1.Visible = false;
                    LblSpecialField2.Text = "Guidedog";
                    LblSpecialField2.Visible = true;
                    TxbSpecialField2.Visible = true;
                    break;

                case "Cat":
                    LblSpecialField1.Text = "Bad behavior";
                    TxbSpecialField1.Visible = true;
                    CmdSpecialField1.Visible = false;
                    LblSpecialField2.Visible = false;
                    TxbSpecialField2.Visible = false;
                    break;

                case "Horse":
                    LblSpecialField1.Text = "Type";
                    TxbSpecialField1.Visible = false;
                    CmdSpecialField1.Visible = true;
                    LblSpecialField2.Visible = false;
                    TxbSpecialField2.Visible = false;
                    break;

                case "Lizard":
                    LblSpecialField1.Text = "Climate";
                    TxbSpecialField1.Visible = true;
                    CmdSpecialField1.Visible = false;
                    LblSpecialField2.Text = "Species";
                    LblSpecialField2.Visible = true;
                    TxbSpecialField2.Visible = true;
                    break;

                case "Parrot":
                    LblSpecialField1.Text = "Can talk";
                    TxbSpecialField1.Visible = true;
                    CmdSpecialField1.Visible = false;
                    LblSpecialField2.Visible = false;
                    TxbSpecialField2.Visible = false;
                    break;
            }

        }

        private void BtnCalculateAge_Click(object sender, EventArgs e)
        {
            Animal selected = LbxAnimalsReserved.SelectedItem as Animal ?? LbxAnimalsNotReserved.SelectedItem as Animal;
            if (selected != null)
            {
                string age = selected.CalculateAnimalAge(selected.DateOfBirth);
                MessageBox.Show(age);
            }
        }


        // values to add
        //CmbAnimalType.SelectedItem = null;
        //TxbAnimalName.Text = null;
        //TxbDateOfBirth.Text = null;
        //CmdSpecialField1.SelectedItem = null; (is for horse)
        //TxbSpecialField1.Text = null; (is for all but horse)
        //TxbSpecialField2.Text = null; (is for lizard)

        private void LbxAnimalsNotReserved_SelectedValueChanged(object sender, EventArgs e)
        {
            LbxAnimalsReserved.SelectedValueChanged -= LbxAnimalsReserved_SelectedValueChanged;
            LbxAnimalsReserved.ClearSelected();

            Animal selected = LbxAnimalsReserved.SelectedItem as Animal ?? LbxAnimalsNotReserved.SelectedItem as Animal;
            if (LbxAnimalsNotReserved.SelectedItems.Count == 1)
            {
                LoadAnimal(selected);
            }
            LbxAnimalsReserved.SelectedValueChanged += LbxAnimalsReserved_SelectedValueChanged;
        }

        private void LbxAnimalsReserved_SelectedValueChanged(object sender, EventArgs e)
        {
            LbxAnimalsNotReserved.SelectedValueChanged -= LbxAnimalsNotReserved_SelectedValueChanged;
            LbxAnimalsNotReserved.ClearSelected();

            Animal selected = LbxAnimalsNotReserved.SelectedItem as Animal ?? LbxAnimalsReserved.SelectedItem as Animal;
            if (LbxAnimalsReserved.SelectedItems.Count == 1)
            {
                LoadAnimal(selected);
            }
            LbxAnimalsNotReserved.SelectedValueChanged += LbxAnimalsNotReserved_SelectedValueChanged;
        }

        private void LblDateOfBirth_MouseHover(object sender, EventArgs e)
        {
            var control = sender as Control;
            Point mousePosition = control.PointToClient(Cursor.Position);
            toolTip.Show("If a date of birth is not known leave it empty.", control, mousePosition.X, mousePosition.Y + 20, 30000);
        }

        private void LblDateOfBirth_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide((Control)sender);
        }

        private void BtnAddLocation_Click(object sender, EventArgs e)
        {
            string name = TxbLocation.Text;
            admin.AddLocation(name);
            TxbLocation.Clear();

            List<Location> locations = admin.LoadLocations();

            LbxLocations.DataSource = locations;
        }

        private void BtnDeleteLocation_Click(object sender, EventArgs e)
        {
            List<Location> locations = admin.LoadLocations();

            var selectedId = Convert.ToInt32(LbxLocations.SelectedValue);
            var locationToDelete = locations.FirstOrDefault(obj => obj.ID == selectedId);
            LbxLocations.DataSource = locations;
            // https://stackoverflow.com/questions/44173337/delete-json-data-inside-property-based-on-id-in-c-sharp
            if (locationToDelete != null)
            {
                locations.Remove(locationToDelete);
                var updatedJson = JsonSerializer.Serialize(locations, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePathToLocations, updatedJson);
            }

            locations = admin.LoadLocations();
            LbxLocations.DataSource = locations;
        }
        private void BtnChangeLocation_Click(object sender, EventArgs e)
        {
            List<Location> locations = admin.LoadLocations();

            var selectedId = Convert.ToInt32(LbxLocations.SelectedValue);
            var locationToDelete = locations.FirstOrDefault(obj => obj.ID == selectedId);

            var animal = LbxAnimalsNotReserved.SelectedItem as Animal;

            if (animal == null)
            {
                animal = LbxAnimalsReserved.SelectedItem as Animal;
            }

            animal.LocationId = selectedId;

            context.SaveChanges();
        }
        private void BtnLocationAnimals_Click(object sender, EventArgs e)
        {
            var selectedLocationId = Convert.ToInt32(LbxLocations.SelectedValue);
            LbxAnimalsNotReserved.DataSource = context.Animals
                .Include(a => (a as Horse).Type)
                .Where(a => !a.IsReserved && a.LocationId == selectedLocationId)
                .ToList();

            LbxAnimalsReserved.DataSource = context.Animals
                .Include(a => (a as Horse).Type)
                .Where(a => a.IsReserved && a.LocationId  == selectedLocationId)
                .ToList();
        }
        private void BtnShowAllAnimals_Click(object sender, EventArgs e)
        {
            LbxAnimalsNotReserved.DataSource = context.Animals
                .Include(a => (a as Horse).Type)
                .Where(a => !a.IsReserved)
                .ToList();

            LbxAnimalsReserved.DataSource = context.Animals
                .Include(a => (a as Horse).Type)
                .Where(a => a.IsReserved)
                .ToList();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CmbAnimalType.SelectedItem = null;
            TxbAnimalName.Text = null;
            TxbDateOfBirth.Text = null;
            CmdSpecialField1.SelectedItem = null;
            TxbSpecialField1.Text = null;
            TxbSpecialField2.Text = null;
        }
        private void LoadAnimal(Animal selected)
        {
            if (selected == null) return;

            CmbAnimalType.Text = selected.GetType().Name;
            TxbAnimalName.Text = selected.Name;
            TxbDateOfBirth.Text = selected.DateOfBirth.ToString();

            switch (selected)
            {
                case Dog dog:
                    TxbSpecialField1.Text = dog.LastWalkDate.ToString();
                    TxbSpecialField2.Text = dog.GuideDog.ToString();
                    break;

                case Cat cat:
                    TxbSpecialField1.Text = cat.BadHabits.ToString();
                    break;

                case Horse horse:
                    CmdSpecialField1.Text = horse.Type.ToString();
                    break;

                case Lizard lizard:
                    TxbSpecialField1.Text = lizard.Climate.ToString();
                    TxbSpecialField2.Text = lizard.Species.ToString();
                    break;

                case Parrot parrot:
                    TxbSpecialField1.Text = parrot.CanTalk.ToString();
                    break;
            }
        }

    }
}
