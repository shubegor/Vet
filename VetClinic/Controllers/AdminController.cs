using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModel;
using System.Web.Http;

namespace VetClinic.Controllers
{
    [RoutePrefix("api/Admin")]
    public class AdminController : ApiController
    {


        private IPetRepository PetRepo;
        private IUserRepository UserRepo;
        private IServiceRepository ServiceRepo;
        public AdminController(IPetRepository repo1, IUserRepository repo2, IServiceRepository repo3)
        {
            PetRepo = repo1;
            UserRepo = repo2;
            ServiceRepo = repo3;
        }

        //-----------------------------------------------Users
        
        [Route("AllClients")]
        [HttpGet]
        public List<User> AllClients()
        {
            List<User> list = null;
            try
            {
                list = UserRepo.GetAllListOfElements().Where(x=>x.Role == 2 ).ToList();

            }
            catch { }
            return list;
        }

        [Route("GetClientById")]
        [HttpGet]
        public User GetClientById(string id)
        {
            return UserRepo.GetElementsById(id);             
        }

        [Route("AllDoctors")]
        [HttpGet]
        public List<User> AllDoctors()
        {
            List<User> list = null;
            try
            {
                list = UserRepo.GetAllListOfElements().Where(x => x.Role == 0).ToList();

            }
            catch { }
            return list;
        }


        [Route("EditClient")]
        [HttpPost]
        public void EditClient(User user)
        {
            UserRepo.UpdateElements(user);
        }


        //-----------------------------------------------Pets

        [Route("AllPet")]
        [HttpGet]
        public List<Pet> AllPet()
        {
            return PetRepo.GetAllListOfElements();
        }


        [Route("EditPet")]
        [HttpPost]
        public void EditPet(Pet pet)
        {
            PetRepo.UpdateElements(pet);
        }
        [Route("GetPet")]
        [HttpGet]
        public void GetPet(string id)
        {
            PetRepo.GetElementsById(id);
        }



        //-----------------------------------------------Services

        [Route("AllClientServices")]
        [HttpGet]
        public List<Service> AllClientServices(string id)
        {
            return ServiceRepo.GetAllUserServices(id);
        }

        [Route("AllServices")]
        [HttpGet]
        public List<ServiceWeb> AllServices()
        {
            List<Service> list = ServiceRepo.GetAllListOfElements();
            List<ServiceWeb> listWeb = new List<ServiceWeb>();
            foreach(var i in list)
            {
                Pet p = PetRepo.GetElementsById(i.IDPet.ToString());
                listWeb.Add(new ServiceWeb {
                    ServiceId = i.ServiceId,
                    DateTimeService = i.DateTimeService,
                    DoctorName = UserRepo.GetElementsById(i.DoctorId.ToString()).Name,
                    PetName = p.Name,
                    OwnerName = p.OwnerName });
            }
            return listWeb;
        }

        [Route("GetService")]
        [HttpGet]
        public Service GetService(string id)
        {

            return ServiceRepo.GetElementsById(id);

        }

        [Route("NewService")]
        [HttpPost]
        public void NewService(Service service)
        {

            service.ServiceId = Guid.NewGuid();

            ServiceRepo.AddElements(service);

        }

        [Route("EditService")]
        [HttpGet]
        public void EditService(string ServiceId, DateTime time, string phone)
        {

            Service s = ServiceRepo.GetElementsById(ServiceId);
            s.Phone = phone;
            s.DateTimeService = time;
            ServiceRepo.UpdateElements(s);
        }

        [Route("DeleteService")]
        [HttpGet]
        public void DeleteService(string id)
        {
            ServiceRepo.DeleteElements(id);
        }





        [Route("GetFreeTime")]
        [HttpGet]
        public List<DateTime> GetFreeTime(string DoctorId, DateTime Date)
        {

            List<DateTime> list = new List<DateTime>();
            DateTime temp = new DateTime(2019, 1, 10, 10, 0, 0);
            for (int i = 0; i < 15; i++)
            {
                list.Add(temp);
                temp = temp.AddMinutes(30);
            }
            //try
            //{
                List<Service> sevices = ServiceRepo.GetAllDoctorServices(DoctorId).Where(x => x.DateTimeService.Date == Date.Date).ToList();
                
                foreach (var i in sevices)
                {
                    list.Remove(list.FirstOrDefault(x => x.Hour == i.DateTimeService.Hour && x.Minute == i.DateTimeService.Minute));        
                }
            //}
            //catch { }
            return list;

        }


        


      

       





    }
}