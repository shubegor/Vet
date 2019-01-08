using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel
{
    public class Vaccination
    {
        [Key]
        public Guid VaccinationId { get; set; }

        public int IDPet { get; set; }
        [ForeignKey("IDPet")]
        public Pet Pet { get; set; }

        public string VaccineName { get; set; }
        public DateTime DateOfVaccination { get; set; }
        public DateTime ExpiredDate { get; set; }

        public bool IsVaccinated { get; set; }
        public string Description { get; set; }


    }
}
