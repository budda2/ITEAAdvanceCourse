using System;

namespace DataModel
{
    public class Child : Person
    {
        public Guid PetId => Pet.Id;
        public Pet Pet { get; set; }
    }
}
