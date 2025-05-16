using AnimalShelter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterUnitTests
{
    [TestClass]
    public class AnimalUnitTests
    {
        private class TestAnimal : Animal
        {
            public TestAnimal(SimpleDate dob, string name) : base(dob, name) { }
        }

        [TestMethod]
        public void AnimalCreation()
        {
            var dob = new SimpleDate(11, 11, 2011);
            var animal = new TestAnimal(dob, "Generic");

            Assert.AreEqual(dob, animal.DateOfBirth);
            Assert.AreEqual("Generic", animal.Name);
            Assert.IsFalse(animal.IsReserved);
        }

        [TestMethod]
        public void ToString_NotReserved()
        {
            var animal = new TestAnimal(new SimpleDate(1, 1, 2000), "Unnamed");
            animal.Id = 101;

            string expected = "101, 01-01-2000, Unnamed, not reserved";
            Assert.AreEqual(expected, animal.ToString());
        }

        [TestMethod]
        public void ToString_Reserved()
        {
            var animal = new TestAnimal(new SimpleDate(2, 2, 2002), "Taken");
            animal.Id = 202;
            animal.IsReserved = true;

            string expected = "202, 02-02-2002, Taken, reserved";
            Assert.AreEqual(expected, animal.ToString());
        }

        [TestMethod]
        public void CalculateAnimalAge_Valid()
        {
            var animal = new TestAnimal(new SimpleDate(15, 5, 2010), "Agey");
            string age = animal.CalculateAnimalAge(animal.DateOfBirth);

            Assert.IsFalse(string.IsNullOrWhiteSpace(age));
            // can't check exact value without mocking date, but we check the method runs and returns a string
        }

        [TestMethod]
        public void LocationId_CanBeNull()
        {
            var animal = new TestAnimal(new SimpleDate(1, 1, 2010), "LoCo");
            Assert.IsNull(animal.LocationId);
        }
    }
}
