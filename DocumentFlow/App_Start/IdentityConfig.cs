using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace DocumentFlow.App_Start
{
    public class IdentityConfig
    {
        public class EmailService : IIdentityMessageService
        {
            public Task SendAsync(IdentityMessage message)
            {
                var from = "enasiyati@gmail.com";
                var pass = "itGeekel7c9";

                var client = new SmtpClient("smtp.gmail.com", 25);

                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(from, pass);
                client.EnableSsl = true;

                var mail = new MailMessage(from, message.Destination);
                mail.Subject = message.Subject;
                mail.Body = message.Body;
                mail.IsBodyHtml = true;

                return client.SendMailAsync(mail);
            }
        }
    }
}