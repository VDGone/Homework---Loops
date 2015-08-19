using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DecimalToHexadecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using loops write a program that converts an integer number to its binary representation.
            //The input is entered as long. The output should be a variable of type string.
            //Do not use the built-in .NET functionality.

            Console.WriteLine("Enter your decimal number: ");
            long dec = long.Parse(Console.ReadLine());

            long rest;
            string binary = string.Empty;

            while (dec > 0)
            {
                rest = dec % 2;
                dec /= 2;
                binary = rest.ToString() + binary;
            }

            Console.WriteLine("Result in binari is: {0}", binary);
        }
    }
}
