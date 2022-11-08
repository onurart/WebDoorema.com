using System.Net;
using System.Net.Mail;
namespace WebDooreme.Models
{
    public class Contacts
    {
        public static void SendMail(string body)
        {
            var fromAddress = new MailAddress("ema@emacelikkapi.com", "Web Sitesinden Gelen İletişim Formu...");
            var toAddress = new MailAddress("ema@emacelikkapi.com");
            const string subject = "Web Sitesinden Gelen İletişim Formu...";
            var smtp = new SmtpClient
            {
                Host = "mail.ema@emacelikkapi.com",
                Port = 25,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "789456em")
            };
            var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body };
            smtp.Send(message);
        }
    }
}