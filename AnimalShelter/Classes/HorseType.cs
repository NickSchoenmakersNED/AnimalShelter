using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Classes
{
    public class HorseType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
