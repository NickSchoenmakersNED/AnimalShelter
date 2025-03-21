using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        private Animal animal;
        private List<Animal> animals;

        public AdministrationForm()
        {
            InitializeComponent();
            CmbAnimalType.SelectedIndex = 0;
            animals = new List<Animal>();
            LbxAnimals.DisplayMember = nameof(Animal.ToString);
        }

        private bool Add(Animal newAnimal)
        {
            foreach (Animal animal in animals)
            {
                if (animal.ChipRegistrationNumber == newAnimal.ChipRegistrationNumber)
                {
                    return false;
                }
            }
            animals.Add(newAnimal);
            return true;
        }

        private bool RemoveAnimal(int chipRegistrationNumber)
        {
            Animal toRemove = null;
            foreach (Animal animal in animals)
            {
                if (animal.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    toRemove = animal;
                    break;
                }
            }
            if (toRemove != null)
            {
                animals.Remove(toRemove);
                return true;
            }
            return false;
        }

        private Animal FindAnimal(int chipRegistrationNumber)
        {
            foreach (Animal animal in animals)
            {
                if (animal.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    return animal;
                }
            }
            return null;
        }

        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            string animalType = CmbAnimalType.SelectedItem.ToString().ToLower();
            string name = TxbAnimalName.Text;
            int chipNumber;

            if (!int.TryParse(TxbChipNumber.Text, out chipNumber))
            {
                MessageBox.Show("Invalid chip number. Please enter a valid number.");
                return;
            }

            if (FindAnimal(chipNumber) != null)
            {
                MessageBox.Show("Chip number already exists. Please generate a new number.");
                return;
            }

            SimpleDate dateOfBirth = new SimpleDate(1, 1, 2020);
            Animal newAnimal = null;

            if (animalType == "dog")
            {
                try
                {
                    string[] parts = TxbSpecialField.Text.Split('-');
                    int day = int.Parse(parts[0]);
                    int month = int.Parse(parts[1]);
                    int year = int.Parse(parts[2]);
                    SimpleDate lastWalk = new SimpleDate(day, month, year);
                    newAnimal = new Dog(chipNumber, dateOfBirth, name, lastWalk);
                }
                catch
                {
                    MessageBox.Show("Invalid date format. Use dd-mm-yyyy.");
                    return;
                }
            }
            else if (animalType == "cat")
            {
                string badHabits = TxbSpecialField.Text;
                newAnimal = new Cat(chipNumber, dateOfBirth, name, badHabits);
            }
            else
            {
                MessageBox.Show("Unsupported animal type.");
                return;
            }

            if (!Add(newAnimal))
            {
                MessageBox.Show("Failed to add animal. Chip number may already exist.");
                return;
            }

            LbxAnimals.DataSource = null;
            LbxAnimals.DataSource = animals;
        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            if (LbxAnimals.SelectedItem != null)
            {
                MessageBox.Show(LbxAnimals.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("No animal created yet.");
            }
        }

        private void BtnChipNumberGenerator_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int min = 1;
            int max = 9999;
            TxbChipNumber.Text = random.Next(min, max).ToString();
        }

        private void CmbAnimalType_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (CmbAnimalType.Text)
            {
                case "Dog":
                    LblLastWalk.Text = "Last walked";
                    break;
                case "Cat":
                    LblLastWalk.Text = "Bad behaviour";
                    break;
                default:
                    LblLastWalk.Text = string.Empty;
                    break;
            }
        }

        private void BtnDeleteAnimal_Click(object sender, EventArgs e)
        {
            if (LbxAnimals.SelectedItem is Animal selectedAnimal)
            {
                if (RemoveAnimal(selectedAnimal.ChipRegistrationNumber))
                {
                    MessageBox.Show("Animal removed.");
                }
                else
                {
                    MessageBox.Show("No animal found with that chip number.");
                }

                LbxAnimals.DataSource = null;
                LbxAnimals.DataSource = animals;
            }
            else
            {
                MessageBox.Show("Please select an animal to remove.");
            }
        }
    }
}
