using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        private Animal animal;

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            CmbAnimalType.SelectedIndex = 0;
            animal = null;
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            string animalType = CmbAnimalType.SelectedItem.ToString().ToLower();
            string name = TxbAnimalName.Text;
            int chipNumber;

            if (!int.TryParse(TxbChipNumber.Text, out chipNumber))
            {
                MessageBox.Show("Invalid chip number. Please enter a valid integer.");
                return;
            }

            // For demo purposes: replace with actual input
            SimpleDate dateOfBirth = new SimpleDate(1, 1, 2020);

            if (animalType == "dog")
            {
                // Special field is a date
                // Attempt to parse the date in format dd-mm-yyyy
                try
                {
                    string[] parts = TxbSpecialField.Text.Split('-');
                    int day = int.Parse(parts[0]);
                    int month = int.Parse(parts[1]);
                    int year = int.Parse(parts[2]);
                    SimpleDate lastWalk = new SimpleDate(day, month, year);
                    animal = new Dog(chipNumber, dateOfBirth, name, lastWalk);
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
                animal = new Cat(chipNumber, dateOfBirth, name, badHabits);
            }
            else
            {
                MessageBox.Show("Unsupported animal type.");
                return;
            }

            // Clear previous and add new to listbox
            LbxAnimals.Items.Clear();
            LbxAnimals.Items.Add(animal.ToString());
        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            if (animal != null)
            {
                MessageBox.Show(animal.ToString());
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
    }
}
