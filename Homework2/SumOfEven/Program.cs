using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEven
{
    class Program
    {
        #region checkIfTheNumberIsEven
        static bool Even(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;

        }
        #endregion

        #region SumOfEvenNumbers
        static int Sum(int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                if (Even(number))
                {
                    result += number;
                }

            }
            return result;
        }
        #endregion
        static void Main(string[] args)
        {
            int[] array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
               Input: Console.WriteLine($"Enter integer no {i+1} :");
                int number;
                bool check = int.TryParse(Console.ReadLine(), out number);
                if(check)
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine("You need to enter a integer!!!");
                    goto Input;
                }
                
            }

            Console.WriteLine($"The result is { Sum(array)}");
            Console.ReadLine();

        }
    }
}
