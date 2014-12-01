namespace Holidays.Interfaces
{
    //CR: This is an assumption. Currently you only have to send an email. But you assumed the other channels will be used.
    public interface INotifier
    {
        //CR: too many parameters here. I would introduce here the concept of EmailMessage or simply Email
        void Notify(string sender, string receiver, string subject, string body);
    }
}