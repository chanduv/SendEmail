namespace SendEmail.Interfaces
{
    public interface IEmail
    {
        void SendEmail(string[] recipientEmail, string subject, string body);
    }
}
