using AnimalShelter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace AnimalShelter
{
    public abstract class Animal : IAnimal
    {
        public int Id { get; set; }
        public SimpleDate DateOfBirth { get; set; }
        public string Name { get; set; }
        public bool IsReserved { get; set; }
        protected Animal() { } // for Entity framework. this needs to be done otherwise it whines about the simpledate
        public int? LocationId { get; set; } // will be for the Json/XML file (havent decided yet). this will not be nessesairy and for stability we will keep it nullable (at least for now).
        public Animal(SimpleDate dateOfBirth, string name)
        {
            DateOfBirth = dateOfBirth;
            Name = name;
            IsReserved = false;
        }
        public override string ToString()
        {
            string IsReservedString;
            if (IsReserved)
            {
                IsReservedString = "reserved";
            }
            else
            {
                IsReservedString = "not reserved";
            }

            string info = Id
                          + ", " + DateOfBirth
                          + ", " + Name
                          + ", " + IsReservedString;
            return info;
        }
        public string CalculateAnimalAge(SimpleDate dateOfBirth)
        {
            return dateOfBirth.CalculateAge(SimpleDate.CurrentDate);
        }
    }
}
