using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class Pet
    {

        [Key]
        public int PetId { get; set; }
        
        public string OwnerName { get; set; }

        public string Name { get; set; }

        public string Species { get; set; }

        public string Breed { get; set; }

        public String Birth { get; set; }

        public bool Gender { get; set; }

        public float Weight { get; set; }

        public string Colour { get; set; }
        
        public Guid OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public User User { get; set; }
    }
}
