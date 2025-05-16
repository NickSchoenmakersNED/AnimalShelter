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
    public class LizardUnitTests
    {
        [TestMethod]
        public void LizardCreation()
        {
            var dob = new SimpleDate(12, 12, 2019);
            var lizard = new Lizard(dob, "Geico", "Desert", "Bearded Dragon");

            Assert.AreEqual(dob, lizard.DateOfBirth);
            Assert.AreEqual("Geico", lizard.Name);
            Assert.AreEqual("Desert", lizard.Climate);
            Assert.AreEqual("Bearded Dragon", lizard.Species);
        }

        [TestMethod]
        public void ToString_Default()
        {
            var lizard = new Lizard(new SimpleDate(1, 1, 2020), "Spike", "Rainforest", "Iguana");
            lizard.Id = 444;

            string expected = "Lizard: 444, 01-01-2020, Spike, not reserved, Climate: Rainforest, Species: Iguana";
            Assert.AreEqual(expected, lizard.ToString());
        }

        [TestMethod]
        public void ToString_Reserved()
        {
            var lizard = new Lizard(new SimpleDate(2, 2, 2021), "Slither", "Swamp", "Monitor");
            lizard.Id = 445;
            lizard.IsReserved = true;

            string expected = "Lizard: 445, 02-02-2021, Slither, reserved, Climate: Swamp, Species: Monitor";
            Assert.AreEqual(expected, lizard.ToString());
        }

        [TestMethod]
        public void InheritsFromAnimal()
        {
            var lizard = new Lizard(new SimpleDate(3, 3, 2018), "Reptar", "Tropical", "Chameleon");
            Assert.IsInstanceOfType(lizard, typeof(Animal));
        }
    }
}
