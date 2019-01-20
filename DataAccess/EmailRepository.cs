using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;
using DataModel;
namespace DataAccess
{
    public class EmailRepository : IEmailRepository
    {
        public async Task SendEmail(string From, string Password, string To, string Subject, string Body)
        {
            await SendEmailAsync(From, Password, To, Subject, Body);
        }

        public async Task SendEmailAsync(string From, string Password, string To, string Subject, string Body)
        {
            MailAddress from = new MailAddress(From, "Вет Клиника");
            // кому отправляем
            MailAddress to = new MailAddress(To);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = Subject;
            // текст письма
            m.Body = "<h2>" + Body + "</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential(From, Password);
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(m);
        }
    }
}
