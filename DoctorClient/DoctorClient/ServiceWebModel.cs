using System;
using System.Runtime.Serialization;
namespace DoctorClient
{
    [DataContract]

    public class ServiceWebModel
    {
        [DataMember]
        public Guid ServiceId { get; set; }
        [DataMember]
        public string DoctorName { get; set; }
        [DataMember]
        public string OwnerName { get; set; }
        [DataMember]
        public string PetName { get; set; }
        [DataMember]
        public string Date { get; set; }
        [DataMember]

        public string Time { get; set; }
    }
}