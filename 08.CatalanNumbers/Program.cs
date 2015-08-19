using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
            //Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

            Console.WriteLine("Enter number for n. N must be in this range (0 <= n <= 100): ");
            int n = int.Parse(Console.ReadLine());
            BigInteger catalanNumber = 1;
            BigInteger factorialN = 1;
            BigInteger factorialNplusOne = 1;
            BigInteger factorialNMultTwo = 1;

            if ((0 <= n) && (n <= 100))
            {
                for (int i = 1; i <= n * 2 ; i++)
                {
                    factorialNMultTwo *= i;        
                }
                for (int j = 1; j <= n + 1; j++)
                {
                    factorialNplusOne *= j;
                }
                for (int m = 1; m <= n; m++)
                {
                    factorialN *= m;
                }
                    catalanNumber = factorialNMultTwo / (factorialNplusOne * factorialN);
                Console.WriteLine("Catalan number: {0}", catalanNumber);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
