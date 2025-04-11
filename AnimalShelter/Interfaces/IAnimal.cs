using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Interfaces
{
    internal interface IAnimal
    {
        string CalculateAnimalAge(SimpleDate dateOfBirth); 
    }
}
