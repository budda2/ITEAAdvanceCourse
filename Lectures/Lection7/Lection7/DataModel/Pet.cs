using System;

namespace DataModel
{
    public class Pet : Animal
    {
        public Guid PetId => Owner.Id;

        public Child Owner { get; set; }
    }
}
