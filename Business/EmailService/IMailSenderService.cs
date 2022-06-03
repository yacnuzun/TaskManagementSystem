using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.EmailService
{
    public interface IMailSenderService
    {
        bool SendMail(EmailMessage emailMessage);
    }
}
