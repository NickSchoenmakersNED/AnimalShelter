using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AnimalShelter.Classes;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Data
{
    public static class DatabaseSeeder
    {
        public static void Seed(AnimalShelterDbContext context)
        {
            if (!context.Animals.Any())
            {
                // Horse types (preset in the AnimalShelterDbContext.cs file)
                var running = context.HorseTypes.FirstOrDefault(t => t.Name == "Running");
                var cargo = context.HorseTypes.FirstOrDefault(t => t.Name == "Cargo");
                var sport = context.HorseTypes.FirstOrDefault(t => t.Name == "Sport");
                var pet = context.HorseTypes.FirstOrDefault(t => t.Name == "Pet");


                // Cats
                context.Cats.AddRange(
                    new Cat(new SimpleDate(1, 1, 2020), "Luna", "scratches furniture"),
                    new Cat(new SimpleDate(3, 2, 2019), "Milo", "climbs curtains"),
                    new Cat(new SimpleDate(5, 3, 2018), "Oliver", "bites hands"),
                    new Cat(new SimpleDate(7, 4, 2017), "Leo", "chases dogs"),
                    new Cat(new SimpleDate(9, 5, 2021), "Simba", "steals food"),
                    new Cat(new SimpleDate(11, 6, 2022), "Chloe", "ignores litter box"),
                    new Cat(new SimpleDate(13, 7, 2023), "Bella", "hides for days"),
                    new Cat(new SimpleDate(15, 8, 2020), "Shadow", "hisses at strangers"),
                    new Cat(new SimpleDate(17, 9, 2019), "Nala", "chews cables"),
                    new Cat(new SimpleDate(19, 10, 2021), "Oscar", "knocks over glasses")
                );

                // Dogs
                context.Dogs.AddRange(
                    new Dog(new SimpleDate(2, 1, 2019), "Rex", new SimpleDate(10, 2, 2024)) { GuideDog = false },
                    new Dog(new SimpleDate(4, 2, 2018), "Buddy", new SimpleDate(11, 2, 2024)) { GuideDog = true },
                    new Dog(new SimpleDate(6, 3, 2017), "Daisy", new SimpleDate(12, 2, 2024)) { GuideDog = false },
                    new Dog(new SimpleDate(8, 4, 2020), "Max", new SimpleDate(13, 2, 2024)) { GuideDog = true },
                    new Dog(new SimpleDate(10, 5, 2021), "Charlie", new SimpleDate(14, 2, 2024)) { GuideDog = false },
                    new Dog(new SimpleDate(12, 6, 2022), "Bailey", new SimpleDate(15, 2, 2024)) { GuideDog = true },
                    new Dog(new SimpleDate(14, 7, 2019), "Maggie", new SimpleDate(16, 2, 2024)) { GuideDog = false },
                    new Dog(new SimpleDate(16, 8, 2018), "Cooper", new SimpleDate(17, 2, 2024)) { GuideDog = true },
                    new Dog(new SimpleDate(18, 9, 2020), "Rocky", new SimpleDate(18, 2, 2024)) { GuideDog = false },
                    new Dog(new SimpleDate(20, 10, 2021), "Sadie", new SimpleDate(19, 2, 2024)) { GuideDog = true }
                );

                // Parrots
                context.Parrots.AddRange(
                    new Parrot(new SimpleDate(1, 1, 2021), "Kiwi", true),
                    new Parrot(new SimpleDate(2, 2, 2021), "Rio", false),
                    new Parrot(new SimpleDate(3, 3, 2021), "Polly", true),
                    new Parrot(new SimpleDate(4, 4, 2021), "Mango", false),
                    new Parrot(new SimpleDate(5, 5, 2021), "Sky", true),
                    new Parrot(new SimpleDate(6, 6, 2021), "Echo", false),
                    new Parrot(new SimpleDate(7, 7, 2021), "Sunny", true),
                    new Parrot(new SimpleDate(8, 8, 2021), "Jade", false),
                    new Parrot(new SimpleDate(9, 9, 2021), "Coco", true),
                    new Parrot(new SimpleDate(10, 10, 2021), "Tiki", false)
                );

                // Lizards
                context.Lizards.AddRange(
                    new Lizard(new SimpleDate(2, 1, 2022), "Spike", "Desert", "Bearded Dragon"),
                    new Lizard(new SimpleDate(4, 2, 2022), "Iggy", "Rainforest", "Green Iguana"),
                    new Lizard(new SimpleDate(6, 3, 2022), "Zilla", "Tropical", "Anole"),
                    new Lizard(new SimpleDate(8, 4, 2022), "Draco", "Woodland", "Flying Dragon"),
                    new Lizard(new SimpleDate(10, 5, 2022), "Rango", "Arid", "Frilled Lizard"),
                    new Lizard(new SimpleDate(12, 6, 2022), "Yoshi", "Wetland", "Water Monitor"),
                    new Lizard(new SimpleDate(14, 7, 2022), "Sal", "Jungle", "Skink"),
                    new Lizard(new SimpleDate(16, 8, 2022), "Nero", "Forest", "Gecko"),
                    new Lizard(new SimpleDate(18, 9, 2022), "Zeke", "Savanna", "Uromastyx"),
                    new Lizard(new SimpleDate(20, 10, 2022), "Gex", "Mountains", "Chameleon")
                );

                // Horses
                context.Horses.AddRange(
                    new Horse(new SimpleDate(3, 1, 2018), "Blaze", running) { HorseTypeId = running.Id },
                    new Horse(new SimpleDate(5, 2, 2018), "Dusty", cargo) { HorseTypeId = cargo.Id },
                    new Horse(new SimpleDate(7, 3, 2018), "Star", sport) { HorseTypeId = sport.Id },
                    new Horse(new SimpleDate(9, 4, 2018), "Maple", pet) { HorseTypeId = pet.Id },
                    new Horse(new SimpleDate(11, 5, 2018), "Shadowfax", running) { HorseTypeId = running.Id },
                    new Horse(new SimpleDate(13, 6, 2018), "Clover", cargo) { HorseTypeId = cargo.Id },
                    new Horse(new SimpleDate(15, 7, 2018), "Windy", sport) { HorseTypeId = sport.Id },
                    new Horse(new SimpleDate(17, 8, 2018), "Misty", pet) { HorseTypeId = pet.Id },
                    new Horse(new SimpleDate(19, 9, 2018), "Ace", running) { HorseTypeId = running.Id },
                    new Horse(new SimpleDate(21, 10, 2018), "Dancer", sport) { HorseTypeId = sport.Id }
                );


                context.SaveChanges();
            }
        }
    }
}
