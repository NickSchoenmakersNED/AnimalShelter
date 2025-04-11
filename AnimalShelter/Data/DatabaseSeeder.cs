using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Data
{
    public static class DatabaseSeeder
    {
        public static void Seed(AnimalShelterDbContext context)
        {
            if (!context.Animals.Any())
            {
                context.Cats.Add(new Cat(1000, new SimpleDate(10, 4, 2018), "Fluffy", "bites"));
                context.Dogs.Add(new Dog(2000, new SimpleDate(13, 2, 2022), "Luna", new SimpleDate(10, 3, 2025)));
                context.Cats.Add(new Cat(1001, new SimpleDate(6, 9, 2021), "Simba", "bites"));
                context.Dogs.Add(new Dog(2001, new SimpleDate(27, 11, 2023), "Simba", new SimpleDate(14, 1, 2024)));
                context.Cats.Add(new Cat(1002, new SimpleDate(24, 7, 2016), "Fluffy", null));
                context.Dogs.Add(new Dog(2002, new SimpleDate(10, 2, 2020), "Max", null));
                context.Cats.Add(new Cat(1003, new SimpleDate(30, 4, 2021), "Rex", null));
                context.Dogs.Add(new Dog(2003, new SimpleDate(6, 9, 2018), "Milo", new SimpleDate(28, 1, 2024)));
                context.Cats.Add(new Cat(1004, new SimpleDate(28, 3, 2021), "Bella", null));
                context.Dogs.Add(new Dog(2004, new SimpleDate(2, 11, 2021), "Fluffy", new SimpleDate(4, 1, 2024)));
                context.Cats.Add(new Cat(1005, new SimpleDate(14, 12, 2015), "Simba", "knocks things over"));
                context.Dogs.Add(new Dog(2005, new SimpleDate(30, 6, 2015), "Rex", null));
                context.Cats.Add(new Cat(1006, new SimpleDate(17, 10, 2021), "Luna", null));
                context.Dogs.Add(new Dog(2006, new SimpleDate(4, 3, 2016), "Fluffy", null));
                context.Cats.Add(new Cat(1007, new SimpleDate(1, 5, 2020), "Mittens", "chews furniture"));
                context.Dogs.Add(new Dog(2007, new SimpleDate(2, 10, 2019), "Bella", new SimpleDate(6, 2, 2025)));
                context.Cats.Add(new Cat(1008, new SimpleDate(4, 3, 2021), "Simba", null));
                context.Dogs.Add(new Dog(2008, new SimpleDate(6, 2, 2019), "Max", new SimpleDate(11, 4, 2023)));
                context.Cats.Add(new Cat(1009, new SimpleDate(3, 4, 2022), "Shadow", "bites"));
                context.Dogs.Add(new Dog(2009, new SimpleDate(26, 6, 2021), "Simba", null));
                context.Cats.Add(new Cat(1010, new SimpleDate(30, 5, 2017), "Charlie", "bites"));
                context.Dogs.Add(new Dog(2010, new SimpleDate(15, 12, 2017), "Max", null));
                context.Cats.Add(new Cat(1011, new SimpleDate(28, 9, 2018), "Rex", "chews furniture"));
                context.Dogs.Add(new Dog(2011, new SimpleDate(8, 6, 2015), "Shadow", null));
                context.Cats.Add(new Cat(1012, new SimpleDate(3, 4, 2022), "Bella", null));
                context.Dogs.Add(new Dog(2012, new SimpleDate(14, 6, 2018), "Shadow", null));
                context.Cats.Add(new Cat(1013, new SimpleDate(18, 5, 2020), "Luna", "scratches"));
                context.Dogs.Add(new Dog(2013, new SimpleDate(15, 5, 2019), "Simba", new SimpleDate(30, 6, 2022)));
                context.Cats.Add(new Cat(1014, new SimpleDate(14, 1, 2019), "Max", "bites"));
                context.Dogs.Add(new Dog(2014, new SimpleDate(4, 1, 2023), "Charlie", null));
                context.Cats.Add(new Cat(1015, new SimpleDate(2, 7, 2020), "Rex", "bites"));
                context.Dogs.Add(new Dog(2015, new SimpleDate(18, 2, 2019), "Charlie", null));
                context.Cats.Add(new Cat(1016, new SimpleDate(15, 2, 2021), "Milo", null));
                context.Dogs.Add(new Dog(2016, new SimpleDate(22, 9, 2017), "Max", null));
                context.Cats.Add(new Cat(1017, new SimpleDate(25, 11, 2021), "Fluffy", "knocks things over"));
                context.Dogs.Add(new Dog(2017, new SimpleDate(6, 4, 2019), "Simba", new SimpleDate(14, 2, 2024)));
                context.Cats.Add(new Cat(1018, new SimpleDate(7, 3, 2016), "Mittens", "chews furniture"));
                context.Dogs.Add(new Dog(2018, new SimpleDate(20, 1, 2023), "Mittens", null));
                context.Cats.Add(new Cat(1019, new SimpleDate(4, 2, 2021), "Max", "bites"));
                context.Dogs.Add(new Dog(2019, new SimpleDate(2, 2, 2021), "Charlie", null));
                context.Cats.Add(new Cat(1020, new SimpleDate(1, 10, 2017), "Charlie", null));
                context.Dogs.Add(new Dog(2020, new SimpleDate(23, 8, 2020), "Bella", null));
                context.Cats.Add(new Cat(1021, new SimpleDate(3, 7, 2022), "Bella", "bites"));
                context.Dogs.Add(new Dog(2021, new SimpleDate(2, 3, 2017), "Fluffy", null));
                context.Cats.Add(new Cat(1022, new SimpleDate(21, 9, 2019), "Simba", "bites"));
                context.Dogs.Add(new Dog(2022, new SimpleDate(9, 6, 2023), "Charlie", new SimpleDate(25, 7, 2024)));
                context.Cats.Add(new Cat(1023, new SimpleDate(13, 8, 2018), "Charlie", "chews furniture"));
                context.Dogs.Add(new Dog(2023, new SimpleDate(7, 3, 2022), "Simba", new SimpleDate(20, 6, 2024)));
                context.Cats.Add(new Cat(1024, new SimpleDate(28, 2, 2015), "Fluffy", null));
                context.Dogs.Add(new Dog(2024, new SimpleDate(20, 12, 2017), "Luna", new SimpleDate(1, 4, 2024)));
                context.Cats.Add(new Cat(1025, new SimpleDate(16, 12, 2016), "Max", "scratches"));
                context.Dogs.Add(new Dog(2025, new SimpleDate(6, 5, 2019), "Charlie", null));
                context.Cats.Add(new Cat(1026, new SimpleDate(12, 4, 2021), "Shadow", "scratches"));
                context.Dogs.Add(new Dog(2026, new SimpleDate(8, 4, 2016), "Milo", new SimpleDate(17, 5, 2024)));
                context.Cats.Add(new Cat(1027, new SimpleDate(20, 7, 2015), "Fluffy", null));
                context.Dogs.Add(new Dog(2027, new SimpleDate(3, 6, 2022), "Charlie", new SimpleDate(6, 3, 2025)));
                context.Cats.Add(new Cat(1028, new SimpleDate(22, 6, 2018), "Mittens", null));
                context.Dogs.Add(new Dog(2028, new SimpleDate(29, 10, 2020), "Shadow", new SimpleDate(26, 2, 2024)));
                context.Cats.Add(new Cat(1029, new SimpleDate(27, 11, 2020), "Rex", null));
                context.Dogs.Add(new Dog(2029, new SimpleDate(24, 5, 2016), "Simba", null));
                context.SaveChanges();
            }
        }
    }
}
