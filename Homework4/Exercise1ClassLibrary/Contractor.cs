using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1ClassLibrary
{
    public class Contractor:Employee


    {   //properties
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }
       
        //methods
        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
        public void CurrentPosition()
        {
            Console.WriteLine(Responsible.Dedepartment); 
        }
    }
}
