using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user
            //                want to be done( +, - , * , / ). Then it returns the result.
            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the Operation: +

            //Expected Output:
            //            The result is: 25

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
                Console.WriteLine("Enter the Second number: ");
                double secondNumber;
                bool number2 = double.TryParse(Console.ReadLine(), out secondNumber);
                if (!number2)
                {
                    Console.WriteLine("You need to write number !!! ");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Enter the Operation: ");
                    string inputOperator = Console.ReadLine();
                    double result;
                    
                 

                    switch (inputOperator)
                    {
                        case "+":
                            result = firstNumber + secondNumber;
                            Console.WriteLine("The result is : " + result);
                            Console.ReadLine();
                            break;
                        case "-":
                            result = firstNumber - secondNumber;
                            Console.WriteLine("The result is : " + result);
                            Console.ReadLine();
                            break;

                        case "*":
                            result = firstNumber * secondNumber;
                            Console.WriteLine("The result is : " + result);
                            Console.ReadLine();
                            break;

                        case "/":
                            result = firstNumber / secondNumber;
                            Console.WriteLine("The result is : " + result);
                            Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("You need to write +,-,* or /");
                            Console.ReadLine();
                            break;
                            

                    }
                }
            }
       

        }
    }
}
