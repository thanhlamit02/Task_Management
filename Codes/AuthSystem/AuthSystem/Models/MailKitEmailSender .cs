using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;
using MailKit.Security;
using System.Net.Mail;
using System.Net;
using SmtpClient = System.Net.Mail.SmtpClient;

namespace AuthSystem.Models
{
    public class SendGridEmailSender : IEmailSender 
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            // email và password người gửi  
            string fromMail = "thanhlam141002@gmail.com";
            string fromPassword = "qxyirpxbyrfvbwbr";

            // Nội dung thư
            MailMessage Message = new MailMessage();
            Message.From = new MailAddress(fromMail);
            Message.Subject = subject;
            Message.To.Add(new MailAddress(email));

            Message.Body = message;

            Message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };
            smtpClient.Send(Message);
        }
    }
}

