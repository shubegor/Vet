using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModel;
using DataAccess;
using System.Web.Http;

namespace VetClinic.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        private IPetRepository PetRepo;
        private IUserRepository UserRepo;
        private IServiceRepository ServiceRepo;
        private IVactinationRepository VactinationRepo;
        public UserController(IPetRepository repo1, IUserRepository repo2, IServiceRepository repo3, IVactinationRepository repo4)
        {
            PetRepo = repo1;
            UserRepo = repo2;
            ServiceRepo = repo3;
            VactinationRepo = repo4;
        }

        [Authorize]
        [Route("AllUserPets")]
        [HttpGet]
        public List<Pet> AllUserPets()
        {
            return PetRepo.GetAllListOfElements().Where(x => x.OwnerId == UserRepo.GetByEmail(User.Identity.Name).UserId).ToList();
            
        }

        [Authorize]
        [Route("GetPet")]
        [HttpGet]
        public void GetPet(string id)
        {
            PetRepo.GetElementsById(id);
        }

        [Route("EditPet")]
        [HttpPost]
        public void EditPet(Pet pet)
        {
            PetRepo.UpdateElements(pet);
        }



        [Authorize]
        [Route("GetServicesPet")]
        [HttpGet]
        public List<Service> GetServicesPet(string id)
        {
            List<Service> temp = ServiceRepo.GetAllPetServices(id);
            foreach (var i in temp)
            {
                i.Doctor = UserRepo.GetElementsById(i.DoctorId.ToString());
                i.ServiceType = ServiceRepo.GetServiceTypes().FirstOrDefault(x => x.ServiceTypeId == i.ServiceTypeId);
            }

            return temp;
        }

        [Route("AllClientServices")]
        [HttpGet]
        public List<Service> AllClientServices()
        {
            return ServiceRepo.GetAllUserServices(UserRepo.GetByEmail(User.Identity.Name).UserId.ToString()).ToList();
        }


        [Authorize]
        [Route("GetVaccinationPet")]
        [HttpGet]
        public List<Vaccination> GetVaccinationPet(string id)
        {
            return VactinationRepo.GetAllListOfElements().Where(x => x.IDPet.ToString() == id).ToList();
        }



        [Route("NewService")]
        [HttpPost]
        public void NewService(Service service)
        {

            service.ServiceId = Guid.NewGuid();
            
            ServiceRepo.AddElements(service);

        }
    }
}