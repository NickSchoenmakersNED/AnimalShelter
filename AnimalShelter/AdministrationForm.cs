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

            if (animalType == "dog")
            {
                try
                {
                    string[] parts = TxbSpecialField1.Text.Split('-');
                    SimpleDate lastWalk = new SimpleDate(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]));
                    newAnimal = new Dog(dateOfBirth, name, lastWalk);
                }
                catch(Exception ex) { 
                    MessageBox.Show("Invalid walk date format."); 
                    return; 
                }
            }
            else if (animalType == "cat")
            {
                string badHabits = TxbSpecialField1.Text;
                newAnimal = new Cat(dateOfBirth, name, badHabits);
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
            LblSpecialField1.Text = CmbAnimalType.Text == "Dog" ? "Last walked" : "Bad behaviour";
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

        private void LbxAnimalsNotReserved_SelectedValueChanged(object sender, EventArgs e)
        {
            LbxAnimalsReserved.SelectedValueChanged -= LbxAnimalsReserved_SelectedValueChanged;
            LbxAnimalsReserved.ClearSelected();

            Animal selected = LbxAnimalsReserved.SelectedItem as Animal ?? LbxAnimalsNotReserved.SelectedItem as Animal;
            if (LbxAnimalsNotReserved.SelectedItems.Count == 1)
            {
                CmbAnimalType.Text = selected.GetType().Name;
                TxbAnimalName.Text = selected.Name;


            }
            LbxAnimalsReserved.SelectedValueChanged += LbxAnimalsReserved_SelectedValueChanged;
        }

        private void LbxAnimalsReserved_SelectedValueChanged(object sender, EventArgs e)
        {
            LbxAnimalsNotReserved.SelectedValueChanged -= LbxAnimalsNotReserved_SelectedValueChanged;
            LbxAnimalsNotReserved.ClearSelected();
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

            MessageBox.Show("Location added.");

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

            MessageBox.Show(animal.LocationId.ToString());

            context.SaveChanges();
        }

        private void BtnLocationAnimals_Click(object sender, EventArgs e)
        {
            var selectedLocationId = Convert.ToInt32(LbxLocations.SelectedValue);
            MessageBox.Show(selectedLocationId.ToString());
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
    }
}
