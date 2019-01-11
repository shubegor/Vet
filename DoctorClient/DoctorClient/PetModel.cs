using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorClient
{
    public class PetModel
    {

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

        
        public UserModel User { get; set; }
    }
}
