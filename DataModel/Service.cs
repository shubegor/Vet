using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Service
    {

        [Key]
        public Guid ServiceId { get; set; }
       
        public Guid DoctorId { get; set; }

       
        public User Doctor { get; set; }


        public int IDPet{ get; set; }

        [ForeignKey("IDPet")]
        public Pet Pet { get; set; }

        public Guid ServiceTypeId { get; set; }

        [ForeignKey("ServiceTypeId")]
        public ServiceType ServiceType { get; set; }

        public DateTime DateTimeService { get; set; }

        public string Anamnesis { get; set; }

        public string Diagnosis { get; set; }

        public string Treatment { get; set; }

        public string Description { get; set; }

        public bool IsPaid { get; set; }

        public string Phone { get; set; }

    }
}
