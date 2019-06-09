using DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Lection7Context : DbContext
    {
        public Lection7Context() : base("Lection7")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Map(p =>
                {
                    p.MapInheritedProperties();
                    p.ToTable("Persons");
                });

            modelBuilder.Entity<Child>()
                .Map(child =>
                {
                    child.MapInheritedProperties();
                    child.ToTable("Children");
                })
                .HasRequired(child => child.Pet)
                .WithRequiredPrincipal(pet => pet.Owner);

            modelBuilder.Entity<Animal>()
                .Map(p =>
                {
                    p.MapInheritedProperties();
                    p.ToTable("Animals");
                });

            modelBuilder.Entity<Pet>()
                .Map(child =>
                {
                    child.MapInheritedProperties();
                    child.ToTable("Pets");
                });
            

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Child> Children { get; set; }

        public DbSet<Animal> Animals { get; set; }

        public DbSet<Pet> Pets { get; set; }
    }
}
