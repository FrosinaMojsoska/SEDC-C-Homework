using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1ClassLibrary
{
    public class CEO:Employee
    {
        //properties
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        //methods
        public void AddSharesPrice(double Number)
        {
            SharesPrice = Number;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees: ");
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }
    }
}
