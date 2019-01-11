using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModel;
using DataAccess;
using System.Web.Http;

namespace VetClinic.Controllers
{
    [RoutePrefix("api/Doctor")]
    public class DoctorController : ApiController
    {
        private IPetRepository PetRepo;
        private IUserRepository UserRepo;
        private IServiceRepository ServiceRepo;
        private IVactinationRepository VactinationRepo;
        public DoctorController(IPetRepository repo1, IUserRepository repo2, IServiceRepository repo3, IVactinationRepository repo4)
        {
            PetRepo = repo1;
            UserRepo = repo2;
            ServiceRepo = repo3;
            VactinationRepo = repo4;
        }

        [Authorize]
        [Route("GetMyName")]
        [HttpGet]
        public string GetMyName()
        {
            return User.Identity.Name + " (" + UserRepo.GetByEmail(User.Identity.Name).Name + ")";
        }


        [Authorize]
        [Route("AllDoctorServices")]
        [HttpGet]
        public List<ServiceWeb> AllDoctorServices()
        {
            List<ServiceWeb> listWeb = new List<ServiceWeb>();
             
            List<Service> list = ServiceRepo.GetAllDoctorServices(UserRepo.GetByEmail(User.Identity.Name).UserId.ToString());

            list = list.Where(x => DateTime.Parse(x.DateTimeService) > DateTime.Now).ToList();
            foreach (var i in list)
            {
                Pet p = PetRepo.GetElementsById(i.IDPet.ToString());
                listWeb.Add(new ServiceWeb
                {
                    ServiceId = i.ServiceId,
                    Date = DateTime.Parse(i.DateTimeService).ToString("dd.MM.yyyy"),
                    Time = DateTime.Parse(i.DateTimeService).ToString("HH:mm"),
                    DoctorName = UserRepo.GetElementsById(i.DoctorId.ToString()).Name,
                    PetName = p.Name,
                    OwnerName = p.OwnerName
                });
            }
            return listWeb;

        }




        [Authorize]
        [Route("AllDoctorPet")]
        [HttpGet]
        public List<Pet> AllDoctorPet()
        {

            List<Pet> list = PetRepo.GetAllListOfElements();
            List<Pet> Result = new List<Pet>();
            List <Service> s = ServiceRepo.GetAllDoctorServices(UserRepo.GetByEmail(User.Identity.Name).UserId.ToString());
            
            foreach(var i in list)
            {
                
                if(s.Exists(x=>x.IDPet == i.PetId))
                {
                    Result.Add(i);
                }
            }
           
            return Result;

        }

        [Authorize]
        [Route("GetServiceTypes")]
        [HttpGet]
        public List<ServiceType> GetServiceTypes()
        {
            return ServiceRepo.GetServiceTypes();
        }

        [Authorize]
        [Route("GetService")]
        [HttpGet]
        public Service GetService(string id)
        {
            Service temp = ServiceRepo.GetElementsById(id);
            temp.Doctor = UserRepo.GetElementsById(temp.DoctorId.ToString());
            temp.Pet = PetRepo.GetElementsById(temp.IDPet.ToString());
            temp.ServiceType = ServiceRepo.GetServiceTypes().FirstOrDefault(x => x.ServiceTypeId == temp.ServiceTypeId);
            return temp;
        }

        [Authorize]
        [Route("GetServicesPet")]
        [HttpGet]
        public List<Service> GetServicesPet(string id)
        {
            List<Service> temp = ServiceRepo.GetAllPetServices(id);
            foreach(var i in temp)
            {
                i.Doctor = UserRepo.GetElementsById(i.DoctorId.ToString());
                i.ServiceType = ServiceRepo.GetServiceTypes().FirstOrDefault(x => x.ServiceTypeId == i.ServiceTypeId);
            }
            
            return temp;
        }


        [Authorize]
        [Route("UpdateService")]
        [HttpPost]
        public void UpdateService(Service service)
        {

            Service temp = ServiceRepo.GetElementsById(service.ServiceId.ToString());
            temp.ServiceTypeId = service.ServiceTypeId;
            temp.Treatment = service.Treatment;
            temp.Diagnosis = service.Diagnosis;
            temp.Anamnesis = service.Anamnesis;
            ServiceRepo.UpdateElements(temp);
        }



        [Authorize]
        [Route("GetPet")]
        [HttpGet]
        public Pet GetPet(string id)
        {
            return PetRepo.GetElementsById(id);
        }


        [Authorize]
        [Route("GetClientById")]
        [HttpGet]
        public User GetClientById(string id)
        {
            return UserRepo.GetElementsById(id);
        }

        [Authorize]
        [Route("GetVaccinationPet")]
        [HttpGet]
        public List<Vaccination> GetVaccinationPet(string id)
        {
            return VactinationRepo.GetAllListOfElements().Where(x => x.IDPet.ToString() == id).ToList();
        }

        [Authorize]
        [Route("NewVaccination")]
        [HttpPost]
        public void NewVaccination(Vaccination v)
        {

            VactinationRepo.AddVaccine(v);
        }

        [Authorize]
        [Route("UpdateVaccination")]
        [HttpGet]
        public void UpdateVaccination(string id, bool IsVaccinated)
        {

            Vaccination v = VactinationRepo.GetAllListOfElements().FirstOrDefault(x => x.VaccinationId.ToString() == id);
            v.IsVaccinated = IsVaccinated;
            VactinationRepo.UpdateVaccine(v);
        }

    }
}