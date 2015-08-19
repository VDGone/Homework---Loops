using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.CalculateFactorialsFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            //In combinatorics, the number of ways to choose k different members out of a group of n different elements 
            //(also known as the number of combinations) is calculated by the following formula: formula 
            //For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
            //Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
            //Try to use only two loops.

            Console.WriteLine("Insert two numbers - n and k(1 < k < n < 100).\nEnter number for n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number for k: ");
            int k = int.Parse(Console.ReadLine());
            BigInteger subtraction = n - k;
            BigInteger factorialSub = 1;
            BigInteger result = 1;
            BigInteger resultOfDivision = 1;

            if ((n > 1) && (k > 1) && (n > k) && (n < 100) && (k < 100))
            {
                for (int i = n; i > k; i--)
                {
                    resultOfDivision *= i;
                    // n! / k! = result
                }

                for (int j = 1; j <= subtraction; j++)
                {
                    factorialSub *= j;
                    // (n - k)! = ...
                }
                result = resultOfDivision / factorialSub;
                //result / (n - k)! =...
                Console.WriteLine("Result is: {0}", result);
            }
            else
            {
                Console.WriteLine("Invalid numbers!");
            }
        }
    }
}
