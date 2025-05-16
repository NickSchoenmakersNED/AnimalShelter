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
    public class ParrotUnitTests
    {
        [TestMethod]
        public void ParrotCreation()
        {
            var dob = new SimpleDate(1, 1, 2021);
            var parrot = new Parrot(dob, "Polly", true);

            Assert.AreEqual(dob, parrot.DateOfBirth);
            Assert.AreEqual("Polly", parrot.Name);
            Assert.IsTrue(parrot.CanTalk);
        }

        [TestMethod]
        public void ToString_CanTalk()
        {
            var parrot = new Parrot(new SimpleDate(2, 2, 2022), "Rio", true);
            parrot.Id = 300;

            string expected = "Parrot: 300, 02-02-2022, Rio, not reserved, Can Talk: True";
            Assert.AreEqual(expected, parrot.ToString());
        }

        [TestMethod]
        public void ToString_CannotTalk()
        {
            var parrot = new Parrot(new SimpleDate(3, 3, 2020), "Mute", false);
            parrot.Id = 301;
            parrot.IsReserved = true;

            string expected = "Parrot: 301, 03-03-2020, Mute, reserved, Can Talk: False";
            Assert.AreEqual(expected, parrot.ToString());
        }

        [TestMethod]
        public void InheritsFromAnimal()
        {
            var parrot = new Parrot(new SimpleDate(5, 5, 2023), "Echo", true);
            Assert.IsInstanceOfType(parrot, typeof(Animal));
        }
    }
}
