using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AnimalShelter.Classes
{

    // Json Source: https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to
    public class Administration
    {
        private readonly AnimalShelterDbContext context;
        private readonly string filePathToLocations = Path.Combine(AppContext.BaseDirectory, "Locations.json");

        public Administration(AnimalShelterDbContext context)
        {
            this.context = context;
            context.Database.EnsureCreated();
        }

        // --------------------------------------------------------------------------------------------------------------
        // Animals managed below
        // --------------------------------------------------------------------------------------------------------------
        public bool AddAnimal(Animal animal)
        {
            var animalId = animal.Id;

            if (context.Animals.Any(a => a.Id == animalId))
            {
                return false;
            }

            context.Animals.Add(animal);
            context.SaveChanges();

            // the below code serialized an animal to useable JSON if we want to use that somewhere, should not be neccesairy. Keeping it here in case of.
            //string jsonString = JsonSerializer.Serialize<Animal>(animal);

            //Console.WriteLine(jsonString);

            return true;
        }

        public bool RemoveAnimal(int id)
        {
            var animal = context.Animals.FirstOrDefault(a => a.Id == id);
            if (animal == null)
            {
                return false;
            }

            context.Animals.Remove(animal);
            context.SaveChanges();
            return true;
        }

        public Animal FindAnimal(int id)
        {
            return context.Animals.FirstOrDefault(a => a.Id == id);
        }

        // --------------------------------------------------------------------------------------------------------------
        // Locations managed below
        // --------------------------------------------------------------------------------------------------------------
        public List<Location> LoadLocations()
        {
            if (!File.Exists(filePathToLocations))
            {
                return new List<Location>();
            }

            string json = File.ReadAllText(filePathToLocations);
            List<Location> locations = JsonSerializer.Deserialize<List<Location>>(json);

            if (locations == null)
            {
                locations = new List<Location>();
            }

            return locations;
        }
        public void AddLocation(string name) 
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Location name cannot be empty.");
                return;
            }

            List<Location> locations = new List<Location>();

            if (File.Exists(filePathToLocations))
            {
                string json = File.ReadAllText(filePathToLocations);
                locations = JsonSerializer.Deserialize<List<Location>>(json);

                if (locations == null)
                {
                    locations = new List<Location>();
                }
            }

            int nextId;
            if (locations.Count > 0)
            {
                nextId = locations.Max(l => l.ID) + 1;
            }
            else
            {
                nextId = 1;
            }

            Location newLocation = new Location
            {
                ID = nextId,
                Name = name
            };

            locations.Add(newLocation);

            string updatedJson = JsonSerializer.Serialize(locations, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePathToLocations, updatedJson);
        }
    }
}
