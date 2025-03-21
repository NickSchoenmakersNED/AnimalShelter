using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Animal
    {
        public int ChipRegistrationNumber { get; private set; }
        public SimpleDate DateOfBirth { get; private set; }
        public string Name { get; private set; }
        public bool IsReserved { get; set; }
        public Animal(int chipRegistrationNumber, SimpleDate dateOfBirth, string name)
        {
            ChipRegistrationNumber = chipRegistrationNumber;
            DateOfBirth = dateOfBirth;
            Name = name;
            IsReserved = false;
        }

        /// <summary>
        /// Retrieve information about this animal
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing the information of this animal.
        ///          The format of the returned string is
        ///          "<ChipRegistrationNumber>, <DateOfBirth>, <Name>, <IsReserved>"
        ///          Where: IsReserved will be "reserved" if reserved or "not reserved" otherwise. 
        /// </returns>
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

            string info = ChipRegistrationNumber
                          + ", " + DateOfBirth
                          + ", " + Name
                          + ", " + IsReservedString;
            return info;
        }
    }
}
