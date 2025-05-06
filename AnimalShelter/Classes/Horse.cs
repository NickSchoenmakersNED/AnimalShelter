using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Classes
{
    public class Horse : Animal
    {
        public int HorseTypeId { get; set; } // Foreign Key

        [ForeignKey("HorseTypeId")]
        public HorseType Type { get; set; }

        public Horse() : base() { }

        public Horse(SimpleDate dateOfBirth, string name, HorseType type) : base(dateOfBirth, name)
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"Horse: {Id}, {DateOfBirth}, {Name}, {(IsReserved ? "reserved" : "not reserved")}, Type: {Type?.Name}";
        }
    }
}
