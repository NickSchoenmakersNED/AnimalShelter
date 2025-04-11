using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter
{
    public class AnimalShelterDbContext: DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Dog> Dogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AnimalShelterDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var simpleDateConverter = new ValueConverter<SimpleDate, DateTime>(
                v => v.Date,               // Convert to database
                v => new SimpleDate(v)     // Convert from database
            );

            modelBuilder.Entity<Animal>().Property(a => a.DateOfBirth).HasConversion(simpleDateConverter);
            modelBuilder.Entity<Dog>().Property(d => d.LastWalkDate).HasConversion(simpleDateConverter);

            modelBuilder.Entity<Cat>().HasBaseType<Animal>();
            modelBuilder.Entity<Dog>().HasBaseType<Animal>();
        }

    }
}
