using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal class PartTimeEmployee : IEmployee
    {

        private string first_name;
        private string Last_name;
        private string department;
        private string job_title;
        private double basic_salary;

        public PartTimeEmployee(string Fname, string Lname, string dept, string job)
        {

            first_name = Fname;
            last_name = Lname;  
            department = dept;
            job_title = job;
         

        }
        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            basic_salary = hoursWorked * ratePerHour;
        }


        public double getSalary()
        {
            return basic_salary;
        }


        string First_name 
        {
            get
            {
                return first_name;
            }
            set
            {
                first_name = value;
            }

        }
        string last_name
        {
            get
            {
                return Last_name;
            }
            set
            {
                Last_name = value;
            }

        }

        string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }

        }

        string Jobtitle
        {
            get
            {
                return job_title;
            }
            set
            {
                job_title = value;
            }

        }
        double Basicsalary
        {
            get
            {
               return basic_salary;
            }
            set
            {
                basic_salary = value;
            }

        }

        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IEmployee.Department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IEmployee.Jobtitle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IEmployee.Basicsalary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    
}
