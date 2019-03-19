using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1ClassLibrary
{
    public class Employee
    {
        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

       // methods
        public void PrintInfo()
        {
            Console.WriteLine($"First Name :{FirstName}, Last Name: { LastName}, Salary: {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public void SetSalary(double salary)
        {
            Salary = salary;
        }

       
    }
}
