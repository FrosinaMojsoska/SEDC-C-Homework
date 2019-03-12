using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static int AgeCalculator(DateTime birthdayDate)
        {

            DateTime today = DateTime.Today;
        

            int age = today.Year - birthdayDate.Year;
            int month = today.Month;
            if(today.Day<birthdayDate.Day)
            {
                month--;

            }
            if(month<birthdayDate.Month)
            {
                age--;
            }

            return age;

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday in format mm.dd.yyyy");
            string stringDate = Console.ReadLine();
            DateTime convertedDate = DateTime.Parse(stringDate);  
            Console.WriteLine(     AgeCalculator(convertedDate)  );
       
            
            Console.ReadLine();
        }
    }
}
