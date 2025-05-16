using AnimalShelter;
using AnimalShelter.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace AnimalShelterUnitTests
{
    [TestClass]
    public class AdministrationUnitTests
    {
        private AnimalShelterDbContext context;
        private Administration admin;

        [TestInitialize]
        public void Init()
        {
            var options = new DbContextOptionsBuilder<AnimalShelterDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            context = new AnimalShelterDbContext(options);
            admin = new Administration(context);
            // https://chatgpt.com/share/68271d69-4d04-8001-a8db-8f4fbf3101a3
        }

        [TestCleanup]
        public void Cleanup()
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }

        [TestMethod]
        public void AddAnimal_ShouldSucceed()
        {
            var cat = new Cat(new SimpleDate(1, 1, 2020), "NewCat", "None");

            var result = admin.AddAnimal(cat);

            Assert.IsTrue(result);
            Assert.AreEqual(1, context.Animals.Count());
        }

        [TestMethod]
        public void AddAnimal_DuplicateId_ShouldFail()
        {
            var cat1 = new Cat(new SimpleDate(1, 1, 2020), "First", "None") { Id = 1 };
            var cat2 = new Cat(new SimpleDate(1, 1, 2021), "Second", "None") { Id = 1 };

            context.Animals.Add(cat1);
            context.SaveChanges();

            var result = admin.AddAnimal(cat2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void RemoveAnimal_ValidId()
        {
            var dog = new Dog(new SimpleDate(1, 1, 2019), "Rover", new SimpleDate(10, 5, 2024)) { Id = 10 };
            context.Animals.Add(dog);
            context.SaveChanges();

            var result = admin.RemoveAnimal(10);

            Assert.IsTrue(result);
            Assert.AreEqual(0, context.Animals.Count());
        }

        [TestMethod]
        public void RemoveAnimal_InvalidId()
        {
            var result = admin.RemoveAnimal(999);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void FindAnimal_ShouldReturnCorrectAnimal()
        {
            var parrot = new Parrot(new SimpleDate(3, 3, 2022), "Birdy", true) { Id = 20 };
            context.Animals.Add(parrot);
            context.SaveChanges();

            var found = admin.FindAnimal(20);

            Assert.IsNotNull(found);
            Assert.AreEqual("Birdy", found.Name);
        }

        [TestMethod]
        public void LoadLocations_EmptyFile()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "Locations.json");
            if (File.Exists(path)) File.Delete(path);

            var result = admin.LoadLocations();

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void AddLocation_WritesToFile()
        {
            var name = "TestLocation";

            admin.AddLocation(name);
            var result = admin.LoadLocations();

            Assert.IsTrue(result.Any(l => l.Name == name));
        }
    }
}
