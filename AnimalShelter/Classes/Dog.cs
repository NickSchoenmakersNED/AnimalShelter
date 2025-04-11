using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Dog : Animal
    {
        public SimpleDate LastWalkDate { get; set; }
        public bool GuideDog { get; set; }
        public Dog() : base() { } // for Entity framework. this needs to be done otherwise it whines about the simpledate
        public Dog(int chipRegistrationNumber, SimpleDate dateOfBirth, string name, SimpleDate lastWalkDate) : base(chipRegistrationNumber, dateOfBirth, name)
        {
            LastWalkDate = lastWalkDate;
        }

        public override string ToString()
        {
            return $"Dog: " + base.ToString();
        }
    }
}
