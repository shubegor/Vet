using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorClient
{
    public class VaccinationModel
    {
        public Guid VaccinationId { get; set; }

        public int IDPet { get; set; }
       
        public PetModel Pet { get; set; }

        public string VaccineName { get; set; }
        public string DateOfVaccination { get; set; }
        public string ExpiredDate { get; set; }

        public bool IsVaccinated { get; set; }
        public string Description { get; set; }
    }
}
