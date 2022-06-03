using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Business.EmailService
{
    public class MailSenderManager : IMailSenderService
    {
        public bool SendMail(EmailMessage emailMessage)
        {
            var mail = new MailMessage()
            {
                From = new MailAddress(emailMessage.SenderMail)
            };
            //foreach (var contacts in emailMessage.Contacts)
            //{
            //    mail.To.Add(new MailAddress(contacts));
            //}
            mail.To.Add(new MailAddress(emailMessage.Contacts));
            mail.Subject= emailMessage.Subject;
            mail.Body= emailMessage.Body;
            mail.IsBodyHtml= true;
            mail.BodyEncoding   = Encoding.UTF8;
            mail.SubjectEncoding = Encoding.UTF8;
            mail.HeadersEncoding= Encoding.UTF8;
            var smtpClient = new SmtpClient("smtp.outlook.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(emailMessage.SenderMail, emailMessage.Password)
            };
            smtpClient.Send(mail);
            return true;
        }
    }
}
