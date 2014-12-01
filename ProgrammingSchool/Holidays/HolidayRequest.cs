using System;

namespace Holidays
{
    public class HolidayRequest
    {
        //CR: we don't need this state
        private enum RequestState
        {
            Unknown,
            New,
            Accepted,
            Rejected
        }

        private RequestState state;
        private RequestState State
        {
            set
            {
                state = value;
            }
        }

        public HolidayRequest(Employee requester, DateTime from, DateTime to)
        {
            EmployeeName = requester.Name;
            EmployeeEmail = requester.Email;
            ManagerName = requester.Manager.Name;
            ManagerEmail = requester.Manager.Email;
            From = from;
            To = to;
        }
        //CR: these represents an employee
        public string EmployeeName { private set; get; }
        public string EmployeeEmail { private set; get; }

        //CR: these represents an employee
        public string ManagerName { private set; get; }
        public string ManagerEmail { private set; get; }

        // holiday period
        //CR: These can be a Period class
        public DateTime From { private set; get; }
        public DateTime To { private set; get; }

        public void Submit()
        {
            State = RequestState.New;
            //CR: This can be null.
            Submitted(this, EventArgs.Empty);
        }

        public void SetAccepted()
        {
            State = RequestState.Accepted;
            //CR: This can be null.
            Accepted(this, EventArgs.Empty);
        }

        public void SetRejected()
        {
            State = RequestState.Rejected;
            //CR: This can be null.
            Rejected(this, EventArgs.Empty);
        }

        public event EventHandler Submitted;
        public event EventHandler Accepted;
        public event EventHandler Rejected;
    }
}