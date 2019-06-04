using DataBase.Migrations;
using DataModel;
using System;
using System.Data.Entity;

namespace DataBase
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("DbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataBaseContext, Configuration>());
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //We mark that property ID is a PK for the Entity
            modelBuilder
                .Entity<Entity>().HasKey(entity => entity.Id);

            modelBuilder.Entity<Person>()
                .Map(m =>
                {
                    m.MapInheritedProperties();
                    m.ToTable("Persons");
                });


            modelBuilder.Entity<Child>()
                .Map(m =>
                {
                    m.MapInheritedProperties();
                    m.ToTable("Children");
                }
            );

            modelBuilder.Entity<Animal>()
                .Map(m =>
                {
                    m.MapInheritedProperties();
                    m.ToTable("Animals");
                });

            modelBuilder.Entity<Pet>()
                .Map(m =>
                {

                    m.MapInheritedProperties();
                    m.ToTable("Pets");
                })
                //We state for 1:0 - 1:1 connection
                //Pet requires a child owner, but child could have no pets.
                .HasRequired<Child>(pet => pet.Owner)
                .WithRequiredPrincipal(owner => owner.Pet);
            


            //We state for 1:1 connection
            //Pet requires a child owner and child requires pet.
            //modelBuilder.Entity<Pet>()
            //    .HasRequired<Child>(pet => pet.Owner)
            //    .WithRequiredPrincipal(owner => owner.Pet);

            base.OnModelCreating(modelBuilder);
        }
    }
}
