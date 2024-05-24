using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal interface IEmployee
    {
         string FirstName {  get; set; }
        string LastName { get; set; }
        string Department { get; set; }
        string Jobtitle  { get; set; }
        string Basicsalary { get; set; }

        void computeSalary(int hoursWorked, double ratePerHour);

        
    }
}

