using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeRecordsApp.Staff;

namespace EmployeeRecordsApp.Staff
{
    public interface IEmployee
    {
         int _staffID { get; }

         string _fullName { get; }

        public string _jobTitle { get; set; }

        public string _department { get; set; }

        DateTime _employmentDate { get; }

        

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
