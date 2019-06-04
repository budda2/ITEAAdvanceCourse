using DataBase;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection7Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var child = new Child
            {
                DateOfBirth = DateTime.Now,
                Id = Guid.NewGuid(),
                Name = "Les",
                Surname = "Podrevianskii"
            };

            var pet = new Pet()
            {
                DateOfBirth = DateTime.Now,
                Id = Guid.NewGuid(),
                Owner = child,
                Alias = "Red"
            };
            child.Pet = pet;

            using (var db = new DataBaseContext())
            {
                var tt = db.Persons.FirstOrDefault();

                var pets = db.Pets.ToList();
                db.Pets.Add(pet);
                db.Persons.Add(child);
                db.Children.Add(child);
                db.SaveChangesAsync().Wait();
            }
        }
    }
}
