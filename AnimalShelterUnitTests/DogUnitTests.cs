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
            int chipNumber = 1;
            var dateOfBirth = new SimpleDate(6, 6, 2016);
            string name = "Rex";
            var lastWalk = new SimpleDate(1, 1, 2023);

            Dog dog = new Dog(dateOfBirth, name, lastWalk);

            Assert.AreEqual(dateOfBirth, dog.DateOfBirth);
            Assert.AreEqual(name, dog.Name);
            Assert.AreEqual(lastWalk, dog.LastWalkDate);
            Assert.IsFalse(dog.IsReserved);
        }

        [TestMethod]
        public void ToString_IsNotReserved()
        {
            var dog = new Dog(new SimpleDate(10, 10, 2019), "Buddy", new SimpleDate(2, 2, 2024));

            string result = dog.ToString();

            string expected = "Dog: 2, 10-10-2019, Buddy, not reserved";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToString_IsReserved()
        {
            var dog = new Dog(new SimpleDate(5, 7, 2020), "Bella", new SimpleDate(15, 3, 2024));
            dog.IsReserved = true;

            string result = dog.ToString();

            string expected = "Dog: 3, 05-07-2020, Bella, reserved";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InheritsFromAnimal()
        {
            Dog dog = new Dog(new SimpleDate(20, 4, 2017), "Rocky", new SimpleDate(1, 1, 2024));

            Assert.IsInstanceOfType(dog, typeof(Animal));
        }
    }
}
