using Holidays.Interfaces;
using Holidays.Notifiers;

namespace Holidays.NotifyPolicies
{
    //CR: This is a Factory not a Policy.
    public class ConsoleNotifyPolicy : INotifyPolicy
    {
        public INotifier CreateNotifier()
        {
            return new ConsoleNotifier();
        }
    }
}