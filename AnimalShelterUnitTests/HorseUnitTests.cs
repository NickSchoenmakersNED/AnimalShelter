using AnimalShelter.Classes;
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
    public class HorseUnitTests
    {
        [TestMethod]
        public void HorseCreation()
        {
            var dob = new SimpleDate(4, 4, 2012);
            var type = new HorseType { Id = 1, Name = "Arabian" };
            var horse = new Horse(dob, "Spirit", type);

            Assert.AreEqual(dob, horse.DateOfBirth);
            Assert.AreEqual("Spirit", horse.Name);
            Assert.AreEqual(type, horse.Type);
            Assert.AreEqual(type.Id, horse.HorseTypeId);
        }

        [TestMethod]
        public void ToString_WhenReserved()
        {
            var horse = new Horse(new SimpleDate(6, 6, 2015), "Blaze", new HorseType { Id = 2, Name = "Mustang" });
            horse.Id = 999;
            horse.IsReserved = true;

            string expected = "Horse: 999, 06-06-2015, Blaze, reserved, Type: Mustang";
            Assert.AreEqual(expected, horse.ToString());
        }

        [TestMethod]
        public void Type_CanBeReturned()
        {
            var type = new HorseType { Id = 5, Name = "Thoroughbred" };
            var horse = new Horse(new SimpleDate(10, 10, 2010), "Jet", type);

            Assert.IsNotNull(horse.Type);
            Assert.AreEqual("Thoroughbred", horse.Type.Name);
        }

        [TestMethod]
        public void InheritsFromAnimal()
        {
            var horse = new Horse(new SimpleDate(7, 7, 2013), "Shadow", new HorseType { Id = 3, Name = "Draft" });
            Assert.IsInstanceOfType(horse, typeof(Animal));
        }
    }
}
