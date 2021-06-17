using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeRecordsApp;

namespace EmployeeRecordsApp.Staff
{
    public class TeamLead:IEmployee
    {
        public int _staffID { get; }

        public string _fullName { get; }

        public string _jobTitle { get; set; }

        public string _department { get; set; }

        public DateTime _employmentDate { get; }

        public TeamLead(int staffID, string fullName, DateTime employmentDate)
        {
            _staffID = staffID;
            _fullName = fullName;
            _employmentDate = employmentDate;
        }

        public int staffID
        {
            get => _staffID;
        }


        public string Name
        {
            get => _fullName;
        }

        public DateTime EmploymentDate
        {
            get => _employmentDate;
        }


        public string JobTitle
        {
            get
            {
                return _jobTitle;
            }

            set
            {
                _jobTitle = value;
            }
        }

        public string Department
        {
            get
            {
                return _department;
            }

            set
            {
                _department = value;
            }
        }


        public void ClockIn()
        {

        }

        public void ClockOut()
        {

        }

        public void Work()
        {

        }

    }
}
