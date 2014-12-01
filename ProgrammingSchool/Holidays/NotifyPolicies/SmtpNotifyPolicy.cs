using Holidays.Interfaces;
using Holidays.Notifiers;

namespace Holidays.NotifyPolicies
{
    //CR: This is a Factory not a Policy.
    public class SmtpNotifyPolicy: INotifyPolicy
    {
        public INotifier CreateNotifier()
        {
            return new SmtpNotifier
            {
                SmtpServer = "...",
                SmtpServerPort = 25
            };
        }
    }
}