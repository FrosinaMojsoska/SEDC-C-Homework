using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    class Program

   
    {
        #region createArray

        static string [] CreateArrey()
        {
            string [] resultArray = new string[5];
            for(int i=0;i<resultArray.Length;i++)
            {
                Console.WriteLine($"Enter the name of student {i+1}");
                string inputStudent = Console.ReadLine();
                resultArray[i] = inputStudent;

            }
            return resultArray;
        }
        #endregion

        #region printElements
        static void Print(string [] array)
        {
            foreach (string student in array)

            {
                Console.WriteLine(student);
            }
        }

        #endregion

        static void Main(string[] args)
        {
            
            string[] studentsG1 = CreateArrey();
            string[] studentsG2 = CreateArrey();
           
            #region checkAndEnterGroupInput

            Console.WriteLine("Enter student group: ( there are 1 and 2 )");
            int group;
            bool check = int.TryParse(Console.ReadLine(), out group);

            if (check)
            {
                if(group==1)
                {
                    Console.WriteLine("The Students in G1 are:");
                    Print(studentsG1);

                }
                else if(group==2)
                {
                    Console.WriteLine("The Students in G2 are:");
                    Print(studentsG2);
                }
                else
                {
                    Console.WriteLine("Number must be 1 or 2");
                }
            }
            else
            {
                Console.WriteLine("The input must be an integer");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
