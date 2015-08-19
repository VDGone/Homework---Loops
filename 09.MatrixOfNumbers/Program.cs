using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MatrixOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
            //and prints a matrix like in the examples below. Use two nested loops.

            Console.WriteLine("Enter number for n in range between (1 <= n <= 20)");
            int n = int.Parse(Console.ReadLine());
            

            if ((1 <= n) && (n <= 20)) 
            {
                Console.WriteLine("Matrix: ");
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write("{0, 3}", row + col);
                    }
                    Console.WriteLine(" ");
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
