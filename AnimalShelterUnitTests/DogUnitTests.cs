using AnimalShelter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AnimalShelterUnitTests
{
    [TestClass]
    public class DogUnitTests
    {
        [TestMethod]
        public void DogCreation()
        {
            var dob = new SimpleDate(1, 6, 2017);
            var lastWalk = new SimpleDate(10, 5, 2024);
            var dog = new Dog(dob, "Buddy", lastWalk);

            Assert.AreEqual(dob, dog.DateOfBirth);
            Assert.AreEqual("Buddy", dog.Name);
            Assert.AreEqual(lastWalk, dog.LastWalkDate);
            Assert.IsFalse(dog.IsReserved);
        }

        [TestMethod]
        public void ToString_DefaultFormat()
        {
            var dog = new Dog(new SimpleDate(2, 2, 2020), "Max", new SimpleDate(1, 1, 2024));
            dog.Id = 222;

            string expected = "Dog: 222, 02-02-2020, Max, not reserved";
            Assert.AreEqual(expected, dog.ToString());
        }

        [TestMethod]
        public void InheritsFromAnimal()
        {
            var dog = new Dog(new SimpleDate(3, 3, 2018), "Charlie", new SimpleDate(5, 5, 2023));
            Assert.IsInstanceOfType(dog, typeof(Animal));
        }

        [TestMethod]
        public void LastWalkDate_NullAllowed()
        {
            var dog = new Dog();
            Assert.IsNull(dog.LastWalkDate);
        }

        [TestMethod]
        public void GuideDog_CanBeSet()
        {
            var dog = new Dog(new SimpleDate(5, 5, 2019), "Rex", new SimpleDate(10, 5, 2024));
            dog.GuideDog = true;

            Assert.IsTrue(dog.GuideDog);
        }
    }
}
