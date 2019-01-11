using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class ServiceWeb
    {


        public Guid ServiceId { get; set; }

        public string DoctorName { get; set; }
        public string OwnerName { get; set; }

        public string PetName { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }


    }
}
