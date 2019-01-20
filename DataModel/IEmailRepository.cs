using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
namespace DataModel
{
    public interface IEmailRepository
    {
         Task SendEmail(string From, string Password, string To, string Subject, string Body);
    }
}
