using System;
using Holidays.Interfaces;

namespace Holidays
{
    public class Employee
    {
        public Employee(ICompany company, string name, string email)
        {
            Company = company;
            Name = name;
            Email = email;
        }
        
        public string Name { private set; get; }
        public string Email { private set; get; }
        
        //CR: the company can be private
        public ICompany Company { private set; get; }
        //CR: there is a dependency between Employee and the Manager which is not required.
        //CR: we need the Manager only for sending the email
        public Manager Manager;

        //CR: we could inject the manager here.
        public HolidayRequest AskForHoliday(DateTime from, DateTime to)
        {
            var request = new HolidayRequest(this, from, to);
            //CR: This is a smell of Demeter's Law violation.
            //CR: You can inject the HolidayProcess into this instance or better you can transform the Company into a service locator
            Company.GetHolidaysProcess().RegisterHolidayRequest(request);
            request.Submit();

            return request;
        }
    }
}