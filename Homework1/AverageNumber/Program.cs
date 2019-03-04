using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            //            Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the third number: 20
            //Enter the four number: 30


            //Expected Output:
            //The average of 10, 15, 20 and 30 is: 18

            Console.WriteLine("Enter the First number: ");
            double firstNumber;
            bool number1 = double.TryParse(Console.ReadLine(), out firstNumber);
            if (!number1)
            {
                Console.WriteLine("You need to write number !!! ");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Enter the second number: ");
                double secondNumber;
                bool number2 = double.TryParse(Console.ReadLine(), out secondNumber);
                if (!number2)
                {
                    Console.WriteLine("You need to write number !!! ");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Enter the third number: ");
                    double thirdNumber;
                    bool number3 = double.TryParse(Console.ReadLine(), out thirdNumber);
                    if (!number3)
                    {
                        Console.WriteLine("You need to write number !!! ");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("Enter the fourth number: ");
                        double fourthNumber;
                        bool number4 = double.TryParse(Console.ReadLine(), out fourthNumber);
                        if (!number4)
                        {
                            Console.WriteLine("You need to write number !!! ");
                            Console.ReadLine();

                        }
                        else
                        {
                            double result;
                            result = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
                            Console.WriteLine("The average of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + " and " + fourthNumber + " is: " + result);
                            Console.ReadLine();
                        }
                    }
                }
            }

   
      
   

        


        }
    }
}
