using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate_N_DividedByK_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
            //Use only one loop.

            Console.WriteLine("Insert two numbers - n and k(1 < k < n < 100).\nEnter number for n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number for k: ");
            int k = int.Parse(Console.ReadLine());
            double resultOfDivision = 1;

            if ((n > 1) && (k > 1) && (n > k) && (n < 100) && (k < 100))
            {
                for (int i = n; i > k; i--)
                {
                    resultOfDivision *= i;
                }
                Console.WriteLine("Result is: {0}", resultOfDivision);
            }
            else
            {
                Console.WriteLine("Invalid numbers!");
            }
        }
    }
}
