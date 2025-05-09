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
        public int HorseTypeId { get; set; }

        [ForeignKey("HorseTypeId")]
        public HorseType Type { get; set; }

        public Horse() : base() { }

        public Horse(SimpleDate dateOfBirth, string name, HorseType type) : base(dateOfBirth, name)
        {
            try
            {
                Type = type;
                HorseTypeId = type.Id;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error creating Horse: {ex.Message}");
                throw;
            }
        }

        public override string ToString()
        {
            return $"Horse: {Id}, {DateOfBirth}, {Name}, {(IsReserved ? "reserved" : "not reserved")}, Type: {Type.Name}";
        }
    }
}
