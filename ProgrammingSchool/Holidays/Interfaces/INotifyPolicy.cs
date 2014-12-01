namespace Holidays.Interfaces
{
    //CR: not a policy but a Factory.
    public interface INotifyPolicy
    {
        INotifier CreateNotifier();
    }
}