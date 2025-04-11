using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Cat : Animal
    {
        public string BadHabits { get; set; }
        public Cat() : base() { } // for Entity framework. this needs to be done otherwise it whines about the simpledate
        public Cat(int chipRegistrationNumber, SimpleDate dateOfBirth, string name, string badHabits) : base(chipRegistrationNumber, dateOfBirth, name)
        {
            BadHabits = badHabits;
        }

        public override string ToString()
        {
            return $"Cat: {Id}, {DateOfBirth}, {Name}, {(IsReserved ? "reserved" : "not reserved")}, {BadHabits}";
        }
    }
}
