using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorClient
{
    public class ServiceModel
    {
        public Guid ServiceId { get; set; }

        public Guid DoctorId { get; set; }


        public UserModel Doctor { get; set; }


        public int IDPet { get; set; }

        
        public PetModel Pet { get; set; }

        public Guid ServiceTypeId { get; set; }

    
        public ServiceTypeModel ServiceType { get; set; }

        public string DateTimeService { get; set; }

        public string Anamnesis { get; set; }

        public string Diagnosis { get; set; }

        public string Treatment { get; set; }

        public string Description { get; set; }

        public bool IsPaid { get; set; }

        public string Phone { get; set; }
    }
}
