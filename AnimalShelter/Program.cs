using AnimalShelter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new AnimalShelterDbContext())
            {
                // uncomment when you want to reset the database
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                DatabaseSeeder.Seed(context);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdministrationForm());
        }
    }
}
