using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateTheFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
            //Use only one loop. Print the result with 5 digits after the decimal point.

            Console.WriteLine("Enter number for n: ");
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double factorialN = 1;
            double numXPowerN = 1;
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                numXPowerN *= x;
                sum += (factorialN / numXPowerN);
            }
            Console.WriteLine("The sum is: {0:F5}", sum );
        }
    }
}
