
using DataModel;
using DB;
using Examples;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBaseUsage();

            var t = new List<string> { "Hello world", "My name is Mykhailo" };
            var class1 = new Class1("");

            Console.ReadKey();
        }

        private static void DataBaseUsage()
        {
            using (var connection = new Lection7Context())
            {
                var id = Guid.Parse("76b2ff18-4bea-45b2-a362-359c55490d79");
                var pet = connection
                    .Pets
                    .Include(p => p.Owner)
                    .Where(p => p.Id == id)
                    .FirstOrDefault();

                var child = connection.Children
                    .Include(c => c.Pet)
                    .Where(c => c.Id == pet.PetId)
                    .FirstOrDefault();
            }
        }
    }
}
