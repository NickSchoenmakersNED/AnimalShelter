using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Classes
{
    public class Lizard : Animal
    {
        public string Climate { get; set; }
        public string Species { get; set; }

        public Lizard() : base() { }

        public Lizard(SimpleDate dateOfBirth, string name, string climate, string species) : base(dateOfBirth, name)
        {
            Climate = climate;
            Species = species;
        }

        public override string ToString()
        {
            return $"Lizard: {Id}, {DateOfBirth}, {Name}, {(IsReserved ? "reserved" : "not reserved")}, Climate: {Climate}, Species: {Species}";
        }
    }
}
