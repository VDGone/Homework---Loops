using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumbersNotDivisibleBy3And7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not 
            //divisible by 3 and 7, on a single line, separated by a space.

            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int result = 0;

            while (result <= number)
            {
                if (result % 3 != 0 && result % 7 != 0)
                {
                    Console.Write( "{0} ", result);
                }
                result++;
            }     
        }
    }
}
