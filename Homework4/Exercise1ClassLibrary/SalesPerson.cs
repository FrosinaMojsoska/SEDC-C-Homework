using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1ClassLibrary
{
    public class SalesPerson:Employee
    {
        //properties
        private double SuccessSaleRevenue { get; set; }

        //constructor
        public SalesPerson(string first, string last)
        {
            FirstName = first;
            LastName = last;
            //SuccessSaleRevenue = success;
            Role = Role.Sales;
            SetSalary(500);
        }

        //methods
        public void AddSuccessRevenue(double number)
        {
            SuccessSaleRevenue = number;
        }

        public override double GetSalary()
        {
            if (SuccessSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if (SuccessSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                return Salary + 1500;
            }
            else
            {
                return Salary;
            }
        }


    }
}
