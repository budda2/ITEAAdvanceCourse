using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class Pet : Animal
    {
        public string Alias { get; set; }

        public Child Owner { get; set; }

        public Guid OwnerId => Owner.Id;
    }
}
