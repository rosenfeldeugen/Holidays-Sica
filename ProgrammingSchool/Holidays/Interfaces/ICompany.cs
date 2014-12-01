
namespace Holidays.Interfaces
{
    //CR: you don't need this interface. At least, until you have to provide a different implementation for the company.
    public interface ICompany
    {
        IHolidaysProcess GetHolidaysProcess();
    }
}
