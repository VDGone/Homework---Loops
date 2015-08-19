using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NumbersFromOneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a 
            //single line, separated by a space.

            Console.WriteLine("Enter number for n: ");
            int number = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= number)
            {
                Console.Write("{0} ", i);
                i++;
            }
        }
    }
}
