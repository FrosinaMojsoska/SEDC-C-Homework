using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the 
            //variables so that the first variable has the second value and the second variable the first value.
            //Please find example below:

            //Test Data:
            //Input the First Number: 5
            //Input the Second Number: 8


            //Expected Output:
            //After Swapping:
            //First Number: 8
            //Second Number: 5


            Console.WriteLine("Enter the First number: ");
            int firstNumber;
            bool number1 = int.TryParse(Console.ReadLine(), out firstNumber);
            if (!number1)
            {
                Console.WriteLine("You need to write number !!! ");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Enter the second number: ");
                int secondNumber;
                bool number2 = int.TryParse(Console.ReadLine(), out secondNumber);
                if (!number2)
                {
                    Console.WriteLine("You need to write number !!! ");
                    Console.ReadLine();

                }
                else
                {
                    int tmp;
                    tmp = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = tmp;
                    Console.WriteLine("After swapping : \n firstNumber is :" + firstNumber + "\n secondNumber is : " + secondNumber);
                    Console.ReadLine();

                }

            }
        }
    }
}
    
