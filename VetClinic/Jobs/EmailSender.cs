using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Quartz;
using DataModel;
using Unity;
using DataAccess;
namespace VetClinic.Jobs
{
    public class EmailSender : IJob
    {

        public async Task Execute(IJobExecutionContext context)
        {
            IUnityContainer container = new UnityContainer();
            IPetRepository PetRepo = container.Resolve<PetRepository>();
            IUserRepository UserRepo = container.Resolve<UserRepository>();
            IServiceRepository ServiceRepo = container.Resolve<ServiceRepository>();
            IEmailRepository EmailRepo = container.Resolve<EmailRepository>();
            var List = ServiceRepo.GetAllListOfElements();
            List<Service> res = new List<Service>();
            foreach (var i in List)
            {
                DateTime dateser = DateTime.Parse(i.DateTimeService);
                TimeSpan span = dateser.Subtract(DateTime.Now);

                if (dateser.Day > DateTime.Now.Day && (int)span.TotalHours < 35)
                {
                    string to = UserRepo.GetElementsById(PetRepo.GetElementsById(i.IDPet.ToString()).OwnerId.ToString()).Email;
                    
                    string body = "Здравствуйте уважаемый клиент! Напоминаем, что вы записаны на прием "
                        + dateser.ToString("dd.MM.yyyy")
                        + " в " + dateser.ToString("HH:mm") + ". ";
                    {
                        await EmailRepo.SendEmail("СЮДА СВОЙ ЕМАЙИЛ", "СЮДА ПАРОЛЬЕМАЙЛА", to, "Напоминание о приеме на завтра", body);
                    }
                }
            }
        }
    }
}