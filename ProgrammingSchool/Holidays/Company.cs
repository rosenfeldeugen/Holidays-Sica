using Holidays.Interfaces;

namespace Holidays
{
    //CR: I see the company as a repository for employees.
    //CR: now is acting more like a service locator for HolidaysProcess
    public class Company: ICompany
    {
        private readonly IHolidaysProcess holidaysProcess;
        //CR: This can be simplified with a service locator. Now you have a dependency on HolidayProcess which is not required for the company.
        public Company(IHolidaysProcess holidaysProcess)
        {
            this.holidaysProcess = holidaysProcess;
        }

        public IHolidaysProcess GetHolidaysProcess()
        {
            return holidaysProcess;
        }
    }
}