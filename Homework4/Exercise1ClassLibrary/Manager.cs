using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1ClassLibrary
{
    public class Manager:Employee
    {
        //properties
        private double Bonus { get; set; }
        public string Dedepartment { get; set; }

        //constructor
        public Manager(string first,string last)
        {
            FirstName = first;
            LastName = last;
            Role = Role.Manager;
        }

        //methods
        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
