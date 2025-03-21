using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Cat : Animal
    {
        public string BadHabits { get; set; }
        public Cat(int chipRegistrationNumber, SimpleDate dateOfBirth, string name, string badHabits) : base(chipRegistrationNumber, dateOfBirth, name)
        {
            BadHabits = badHabits;
        }

        /// <summary>
        /// Retrieve information about this cat
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing the information of this animal.
        ///          The format of the returned string is
        ///          "Cat: <ChipRegistrationNumber>, <DateOfBirth>, <Name>, <IsReserved>, <BadHabits>"
        ///          Where: IsReserved will be "reserved" if reserved or "not reserved" otherwise.
        ///                 BadHabits will be "none" if the cat has no bad habits, or the bad habits string otherwise.
        /// </returns>
        public override string ToString()
        {
            return $"Cat: {ChipRegistrationNumber}, {DateOfBirth}, {Name}, {(IsReserved ? "reserved" : "not reserved")}, {BadHabits}";
        }
    }
}
