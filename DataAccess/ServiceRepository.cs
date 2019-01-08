using System;
using System.Collections.Generic;
using System.Linq;
using DataModel;

namespace DataAccess
{
    public class ServiceRepository : IServiceRepository
    {
        VetContext vetdb;
        public ServiceRepository()
        {
            this.vetdb = new VetContext();
        }

        public void AddElements(Service element)
        {
            vetdb.Services.Add(element);
            vetdb.SaveChanges();
        }

        public void DeleteElements(string id)
        {
            var _service = vetdb.Services.Find(new Guid(id));
            vetdb.Services.Remove(_service);
            vetdb.SaveChanges();
        }

        public List<Service> GetAllListOfElements()
        {
            List<Service> _services = vetdb.Set<Service>().ToList();
            return _services;
        }

        public List<Service> GetAllPetServices(string PetId)
        {
            List<Service> _services = vetdb.Set<Service>().Where(x=> x.IDPet.ToString() == PetId).ToList();
            return _services;
        }
        public List<Service> GetAllUserServices(string id)
        {
            
            List<Service> _services = vetdb.Set<Service>().Where(x => x.Pet.OwnerId == new Guid(id)).ToList();
            return _services;
        }



        public List<Service> GetAllDoctorServices(string id)
        {
            List<Service> _services = vetdb.Set<Service>().Where(x => x.DoctorId == new Guid(id)).ToList();
            return _services;
        }

        public Service GetElementsById(string id)
        {
            var _service = vetdb.Services.Find(new Guid(id));
            return _service;
        }

        public void UpdateElements(Service element)
        {
            Service service = vetdb.Services.Find(element.ServiceId);
            service.Anamnesis = element.Anamnesis;
            service.DateTimeService = element.DateTimeService;
            service.Diagnosis = element.Diagnosis;
            service.Description = element.Description;
            service.Phone = element.Phone;
            service.Treatment = element.Treatment;
            service.DoctorId = element.DoctorId;
            service.Doctor = vetdb.Users.Find(element.DoctorId);
            service.IDPet = element.IDPet;
            service.Pet = vetdb.Pets.Find(element.IDPet);

            vetdb.SaveChanges();
        }


        public List<ServiceType> GetServiceTypes()
        {
            List<ServiceType> _services = vetdb.Set<ServiceType>().ToList();
            return _services;
        }
    }
}
