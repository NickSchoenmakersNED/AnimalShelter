﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Classes
{
    public class Administration
    {
        private readonly AnimalShelterDbContext context;

        public Administration(AnimalShelterDbContext context)
        {
            context.Database.EnsureCreated();
        }

        public bool AddAnimal(Animal animal)
        {
            if (context.Animals.Any(a => a.Id == animal.Id))
            {
                return false;
            }

            context.Animals.Add(animal);
            context.SaveChanges();
            return true;
        }

        public bool RemoveAnimal(int chipRegistrationNumber)
        {
            var animal = context.Animals.FirstOrDefault(a => a.Id == chipRegistrationNumber);
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
    }
}
