using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Class
{
    public class Student
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumGender Gender { get; set; }
        public double AverageGrade { get; set; }

        //constructor
        public Student(string firstName,string last,EnumGender gender,double grade)
        {
            FirstName = firstName;
            LastName = last;
            Gender = gender;
            AverageGrade = grade;
        }

        //methods
        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

    }
}
