using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public interface IServiceRepository
    {

        void AddElements(Service element);
        void DeleteElements(string id);
        List<Service> GetAllListOfElements();
        List<Service> GetAllPetServices(string PetId);
        List<Service> GetAllUserServices(string id);
        List<Service> GetAllDoctorServices(string id);
        Service GetElementsById(string id);
        void UpdateElements(Service element);
        List<ServiceType> GetServiceTypes();
        
         
        }
}
