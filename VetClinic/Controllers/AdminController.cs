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
        public Pet GetPet(string id)
        {
            return PetRepo.GetElementsById(id);
        }



        //-----------------------------------------------Services

        [Route("AllClientServices")]
        [HttpGet]
        public List<Service> AllClientServices(string id)
        {
            List<Service> temp = ServiceRepo.GetAllUserServices(id);
            foreach (var i in temp)
            {
                i.Doctor = UserRepo.GetElementsById(i.DoctorId.ToString());
                i.ServiceType = ServiceRepo.GetServiceTypes().FirstOrDefault(x => x.ServiceTypeId == i.ServiceTypeId);
                i.Pet = PetRepo.GetElementsById(i.IDPet.ToString());

            }
            return temp;
        }

        [Route("AllServices")]
        [HttpGet]
        public List<Service> AllServices()
        {
            List<Service> temp = ServiceRepo.GetAllListOfElements();
            foreach (var i in temp)
            {
                i.Doctor = UserRepo.GetElementsById(i.DoctorId.ToString());
                i.ServiceType = ServiceRepo.GetServiceTypes().FirstOrDefault(x => x.ServiceTypeId == i.ServiceTypeId);
                i.Pet = PetRepo.GetElementsById(i.IDPet.ToString());

            }
            temp = temp.OrderByDescending(x => DateTime.Parse(x.DateTimeService)).ToList();
            return temp;
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
            s.DateTimeService = time.ToString("yyyy-MM-ddTHH:mm");
            ServiceRepo.UpdateElements(s);
        }

        [Route("ChangePay")]
        [HttpGet]
        public void ChangePay(string ServiceId, bool IsPaid)
        {
            Service s = ServiceRepo.GetElementsById(ServiceId);
            s.IsPaid = IsPaid;
            ServiceRepo.UpdateElements(s);
        }

        [Route("DeleteService")]
        [HttpGet]
        public void DeleteService(string id)
        {
            ServiceRepo.DeleteElements(id);
        }

        [Route("GetServiceTypes")]
        [HttpGet]
        public List<ServiceType> GetServiceTypes()
        {
            return ServiceRepo.GetServiceTypes();
        }




        [Route("GetFreeTime")]
        [HttpGet]
        public List<DateTime> GetFreeTime(string DoctorId, DateTime Date)
        {

            List<DateTime> list = new List<DateTime>();
            DateTime temp = new DateTime(Date.Year, Date.Month, Date.Day, 10, 0, 0);
            for (int i = 0; i < 15; i++)
            {
                list.Add(temp);
                temp = temp.AddMinutes(30);
            }
            //try
            //{
                List<Service> sevices = ServiceRepo.GetAllDoctorServices(DoctorId).Where(x => DateTime.Parse(x.DateTimeService).Date == Date.Date).ToList();
                
                foreach (var i in sevices)
                {
                    list.Remove(list.FirstOrDefault(x => x.Hour == DateTime.Parse(i.DateTimeService).Hour && x.Minute == DateTime.Parse(i.DateTimeService).Minute));        
                }
            //}
            //catch { }
            return list;

        }


        


      

       





    }
}