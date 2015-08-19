using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using loops write a program that converts a binary integer number to its decimal form.
            //The input is entered as string. The output should be a variable of type long.
            //Do not use the built-in .NET functionality.

            Console.WriteLine("Enter your binary number: ");
            string binary = Console.ReadLine();

            long dec = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - i - 1] == '0')
                {
                    continue;
                }

                dec += (long)Math.Pow(2, i);
            }

            Console.WriteLine("Your number in decimal: {0}", dec);
        }
    }
}
