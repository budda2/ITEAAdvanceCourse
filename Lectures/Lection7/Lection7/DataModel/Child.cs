using System;

namespace DataModel
{
    public class Child : Person
    {
        public Pet Pet { get; set; }

        public Guid PetId => Pet.Id;
    }
}
