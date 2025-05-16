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
            cat.Id = 456;

            string expected = "Cat: 456, 15-03-2020, Luna, not reserved, Bites cables";
            Assert.AreEqual(expected, cat.ToString());
        }

        [TestMethod]
        public void ToString_WhenReserved_NoBadHabits()
        {
            var cat = new Cat(new SimpleDate(1, 1, 2018), "Milo", "none");
            cat.Id = 789;
            cat.IsReserved = true;

            string expected = "Cat: 789, 01-01-2018, Milo, reserved, none";
            Assert.AreEqual(expected, cat.ToString());
        }

        [TestMethod]
        public void ToString_EmptyBadHabits()
        {
            var cat = new Cat(new SimpleDate(25, 12, 2019), "Snowball", "");
            cat.Id = 321;

            string expected = "Cat: 321, 25-12-2019, Snowball, not reserved, ";
            Assert.AreEqual(expected, cat.ToString());
        }

        [TestMethod]
        public void InheritsFromAnimal()
        {
            var cat = new Cat(new SimpleDate(5, 5, 2017), "Felix", "none");
            Assert.IsInstanceOfType(cat, typeof(Animal));
        }

        [TestMethod]
        public void BadHabits_CanBeNull()
        {
            var cat = new Cat(new SimpleDate(1, 1, 2020), "Tom", null);
            Assert.IsNull(cat.BadHabits);
        }

        [TestMethod]
        public void IsReserved_CanBeSet()
        {
            var cat = new Cat(new SimpleDate(1, 1, 2020), "Jerry", "Climbs curtains");
            Assert.IsFalse(cat.IsReserved);

            cat.IsReserved = true;
            Assert.IsTrue(cat.IsReserved);
        }
    }
}
