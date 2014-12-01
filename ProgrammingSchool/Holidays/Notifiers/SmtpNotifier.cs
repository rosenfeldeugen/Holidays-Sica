using System.Net.Mail;
using Holidays.Interfaces;

namespace Holidays.Notifiers
{
    public class SmtpNotifier : INotifier
    {
        //CR: This state can be internal. You can read the SMTP settings from a configuration file.
        public string SmtpServer;
        public int SmtpServerPort;

        public void Notify(string sender, string receiver, string subject, string body)
        {
            using (var mailClient = new SmtpClient(SmtpServer, SmtpServerPort))
            {
                mailClient.Send(sender, receiver, subject, body);
            }
        }
    }
}