using Business.EmailService;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class SendMailController : Controller
    {
        IMailSenderService _emailService;

        public SendMailController(IMailSenderService emailService)
        {
            _emailService = emailService;
        }
        
        [HttpPost]
        public IActionResult Send()
        {
            EmailMessage message = new EmailMessage()
            {
                Body = "Deneme",
                Subject = "Test",
                SenderMail = "yalcin.uzun96@outlook.com",
                Password = "asdfgh_22",
                Contacts = "yacn.uzun@gmail.com"
            };
            _emailService.SendMail(message);
            return RedirectToAction("Index");
        }
    }
}
