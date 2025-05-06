using AnimalShelter;
using AnimalShelter.Classes;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
                    new Cat(new SimpleDate(2020, 1, 1), "Luna", "scratches furniture"),
                    new Cat(new SimpleDate(2019, 2, 3), "Milo", "climbs curtains"),
                    new Cat(new SimpleDate(2018, 3, 5), "Oliver", "bites hands"),
                    new Cat(new SimpleDate(2017, 4, 7), "Leo", "chases dogs"),
                    new Cat(new SimpleDate(2021, 5, 9), "Simba", "steals food"),
                    new Cat(new SimpleDate(2022, 6, 11), "Chloe", "ignores litter box"),
                    new Cat(new SimpleDate(2023, 7, 13), "Bella", "hides for days"),
                    new Cat(new SimpleDate(2020, 8, 15), "Shadow", "hisses at strangers"),
                    new Cat(new SimpleDate(2019, 9, 17), "Nala", "chews cables"),
                    new Cat(new SimpleDate(2021, 10, 19), "Oscar", "knocks over glasses")
                );

                // Dogs
                context.Dogs.AddRange(
                    new Dog(new SimpleDate(2019, 1, 2), "Rex", new SimpleDate(2024, 2, 10)) { GuideDog = false },
                    new Dog(new SimpleDate(2018, 2, 4), "Buddy", new SimpleDate(2024, 2, 11)) { GuideDog = true },
                    new Dog(new SimpleDate(2017, 3, 6), "Daisy", new SimpleDate(2024, 2, 12)) { GuideDog = false },
                    new Dog(new SimpleDate(2020, 4, 8), "Max", new SimpleDate(2024, 2, 13)) { GuideDog = true },
                    new Dog(new SimpleDate(2021, 5, 10), "Charlie", new SimpleDate(2024, 2, 14)) { GuideDog = false },
                    new Dog(new SimpleDate(2022, 6, 12), "Bailey", new SimpleDate(2024, 2, 15)) { GuideDog = true },
                    new Dog(new SimpleDate(2019, 7, 14), "Maggie", new SimpleDate(2024, 2, 16)) { GuideDog = false },
                    new Dog(new SimpleDate(2018, 8, 16), "Cooper", new SimpleDate(2024, 2, 17)) { GuideDog = true },
                    new Dog(new SimpleDate(2020, 9, 18), "Rocky", new SimpleDate(2024, 2, 18)) { GuideDog = false },
                    new Dog(new SimpleDate(2021, 10, 20), "Sadie", new SimpleDate(2024, 2, 19)) { GuideDog = true }
                );

                // Parrots
                context.Parrots.AddRange(
                    new Parrot(new SimpleDate(2021, 1, 1), "Kiwi", true),
                    new Parrot(new SimpleDate(2021, 2, 2), "Rio", false),
                    new Parrot(new SimpleDate(2021, 3, 3), "Polly", true),
                    new Parrot(new SimpleDate(2021, 4, 4), "Mango", false),
                    new Parrot(new SimpleDate(2021, 5, 5), "Sky", true),
                    new Parrot(new SimpleDate(2021, 6, 6), "Echo", false),
                    new Parrot(new SimpleDate(2021, 7, 7), "Sunny", true),
                    new Parrot(new SimpleDate(2021, 8, 8), "Jade", false),
                    new Parrot(new SimpleDate(2021, 9, 9), "Coco", true),
                    new Parrot(new SimpleDate(2021, 10, 10), "Tiki", false)
                );

                // Lizards
                context.Lizards.AddRange(
                    new Lizard(new SimpleDate(2022, 1, 2), "Spike", "Desert", "Bearded Dragon"),
                    new Lizard(new SimpleDate(2022, 2, 4), "Iggy", "Rainforest", "Green Iguana"),
                    new Lizard(new SimpleDate(2022, 3, 6), "Zilla", "Tropical", "Anole"),
                    new Lizard(new SimpleDate(2022, 4, 8), "Draco", "Woodland", "Flying Dragon"),
                    new Lizard(new SimpleDate(2022, 5, 10), "Rango", "Arid", "Frilled Lizard"),
                    new Lizard(new SimpleDate(2022, 6, 12), "Yoshi", "Wetland", "Water Monitor"),
                    new Lizard(new SimpleDate(2022, 7, 14), "Sal", "Jungle", "Skink"),
                    new Lizard(new SimpleDate(2022, 8, 16), "Nero", "Forest", "Gecko"),
                    new Lizard(new SimpleDate(2022, 9, 18), "Zeke", "Savanna", "Uromastyx"),
                    new Lizard(new SimpleDate(2022, 10, 20), "Gex", "Mountains", "Chameleon")
                );

                // Horses
                context.Horses.AddRange(
                    new Horse(new SimpleDate(2018, 1, 3), "Blaze", running),
                    new Horse(new SimpleDate(2018, 2, 5), "Dusty", cargo),
                    new Horse(new SimpleDate(2018, 3, 7), "Star", sport),
                    new Horse(new SimpleDate(2018, 4, 9), "Maple", pet),
                    new Horse(new SimpleDate(2018, 5, 11), "Shadowfax", running),
                    new Horse(new SimpleDate(2018, 6, 13), "Clover", cargo),
                    new Horse(new SimpleDate(2018, 7, 15), "Windy", sport),
                    new Horse(new SimpleDate(2018, 8, 17), "Misty", pet),
                    new Horse(new SimpleDate(2018, 9, 19), "Ace", running),
                    new Horse(new SimpleDate(2018, 10, 21), "Dancer", sport)
                );

                context.SaveChanges();
            }
        }
    }
}
