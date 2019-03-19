using Exercise1ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Contractor constractor1 = new Contractor() { FirstName = "Bob", LastName = "Bobert", Role = Role.Other };
            Contractor constractor2 = new Contractor() { FirstName = "Rick", LastName = "Rickert", Role = Role.Other };
            Manager manager1 = new Manager( "Mona", "Monalisa" );
            Manager manager2 = new Manager("Igor", "Igorsky");
            SalesPerson salePeson1 = new SalesPerson("Lea", "Leova");
            Employee[] Company = { constractor1, constractor2 ,manager1,manager2,salePeson1};
            CEO ceo1 = new CEO() { FirstName = "Ron", LastName = "Ronsky", Role = Role.Other,Shares=300 };
            ceo1.SetSalary(1500);
            ceo1.Employees = Company;
            Console.WriteLine("CEO: ");
            ceo1.PrintInfo();
            ceo1.AddSharesPrice(200);
            Console.WriteLine($"Salary of CEO  is: {ceo1.GetSalary()}");
            ceo1.PrintEmployees();
            //CurrentPosition 
            //manager1.Dedepartment = "department1";
            //constractor1.Responsible = manager1;
            //constractor1.CurrentPosition();
            Console.ReadLine();
        }
    }
}
