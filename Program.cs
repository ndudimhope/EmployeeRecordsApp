using EmployeeRecordsApp.Staff;
using System;

namespace EmployeeRecordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Instantiating Employee Class
            Employee employee1 = new(001, "John Boyega", DateTime.Now);
            Employee employee2 = new(002, "David Gattah", DateTime.Now);
            Employee employee3 = new(003, "Temitope Kolawole", DateTime.Now);
            Employee employee4 = new(004, "Durowoju Oladipo", DateTime.Now);
            Employee employee5 = new(005, "Ademosun Cephas", DateTime.Now);

            employee1.JobTitle = "Product Designer";
            employee1.Department = "Product Development";

            employee2.JobTitle = "Accountant";
            employee2.Department = "Finance";

            employee3.JobTitle = "Backend Engineer";
            employee3.Department = "Software Development";

            employee4.JobTitle = "DevOps Engineer";
            employee4.Department = "Software Development";

            employee5.JobTitle = "Backend Engineer";
            employee5.Department = "Software Development";

            Employee[] employees = new Employee[]
            {
                employee1,employee2,employee3,employee4,employee5
            };

            foreach (Employee i in employees)
            {


                Console.WriteLine(i.staffID + "\t\t" + i.Name + "\t\t" + i.JobTitle + "\t\t" + i.Department + "\t\t" + i.EmploymentDate + "\n");

            }




        }
    }
}
