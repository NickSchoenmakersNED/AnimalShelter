using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Classes
{
    public class Parrot : Animal
    {
        public bool CanTalk { get; set; }

        public Parrot() : base() { }

        public Parrot(SimpleDate dateOfBirth, string name, bool canTalk) : base(dateOfBirth, name)
        {
            CanTalk = canTalk;
        }

        public override string ToString()
        {
            return $"Parrot: {Id}, {DateOfBirth}, {Name}, {(IsReserved ? "reserved" : "not reserved")}, Can Talk: {CanTalk}";
        }
    }
}
