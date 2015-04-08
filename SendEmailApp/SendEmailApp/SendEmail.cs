using System.Collections.Generic;
using SendEmail.Concrete;

namespace SendEmailApp
{
    public static class SendEmail
    {
        public static void Main(string[] args)
        {
            var recipientEmails = new List<string> {"email1@someprovider.com", "email2@someprovider.com"};
            var emailSender = new Email();
            emailSender.SendEmail(recipientEmails.ToArray(), "Test email", "Test email Body");
        }
    }
}
