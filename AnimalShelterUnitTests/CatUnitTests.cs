using AnimalShelter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AnimalShelterUnitTests
{
    [TestClass]
    public class CatUnitTests
    {
        [TestMethod]
        public void CatCreation()
        {
            // i have to do some stuff with id here.
            int chipNumber = 123;
            var dob = new SimpleDate(10, 5, 2015);
            string name = "Whiskers";
            string badHabits = "Scratches furniture";

            Cat cat = new Cat(dob, name, badHabits);

            Assert.AreEqual(dob, cat.DateOfBirth);
            Assert.AreEqual(name, cat.Name);
            Assert.AreEqual(badHabits, cat.BadHabits);
            Assert.IsFalse(cat.IsReserved);
        }

        [TestMethod]
        public void ToString_IsNotReserved_WithBadHabits()
        {
            var cat = new Cat(new SimpleDate(15, 3, 2020), "Luna", "Bites cables");

            string result = cat.ToString();

            string expected = "Cat: 456, 15-03-2020, Luna, not reserved, Bites cables";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToString_WhenReserved_NoBadHabits()
        {
            var cat = new Cat(new SimpleDate(1, 1, 2018), "Milo", "none");
            cat.IsReserved = true;

            string result = cat.ToString();

            string expected = "Cat: 789, 01-01-2018, Milo, reserved, none";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToString_EmptyBadHabits()
        {
            var cat = new Cat(new SimpleDate(25, 12, 2019), "Snowball", "");
            string expected = "Cat: 321, 25-12-2019, Snowball, not reserved, ";

            string result = cat.ToString();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InheritsFromAnimal()
        {
            Cat cat = new Cat(new SimpleDate(5, 5, 2017), "Felix", "none");

            Assert.IsInstanceOfType(cat, typeof(Animal));
        }
    }
}
