using System;
using System.Configuration;
using System.Net.Mail;
using SendEmail.Interfaces;
using SendGrid;
using SendGrid.Transport;

namespace SendEmail.Concrete
{
    public class Email: IEmail
    {
        public void SendEmail(string[] recipientEmails, string subject, string body)
        {
            var message = Mail.GetInstance();
            message.From = new MailAddress(ConfigurationManager.AppSettings["FromEmail"]);
            message.AddTo(recipientEmails);
            message.Subject = subject;
            message.Text = body;

            var credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["UserName"], ConfigurationManager.AppSettings["Password"]);
            var smtpInstance = SMTP.GetInstance(credentials, port: Convert.ToInt32(ConfigurationManager.AppSettings["portNumber"]));

            smtpInstance.DeliverAsync(message);
        }
    }
}