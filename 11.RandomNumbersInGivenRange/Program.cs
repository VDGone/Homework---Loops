using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RandomNumbersInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max]

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("min = ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("max = ");
            int max = int.Parse(Console.ReadLine());

            if (min <= max)
            {
                Random randomNumbers = new Random();

                for (int i = 0; i < n; i++)
                {
                    Console.Write(randomNumbers.Next(min, max + 1) + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
