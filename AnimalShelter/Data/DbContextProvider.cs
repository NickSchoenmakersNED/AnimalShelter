using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Data
{
    public static class DbContextProvider
    {
        private static AnimalShelterDbContext context;

        public static AnimalShelterDbContext Context
        {
            get
            {
                if (context == null)
                    context = new AnimalShelterDbContext();
                return context;
            }
        }
    }
}
