using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexadecimalToDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using loops write a program that converts a hexadecimal integer number to its decimal form.
            //The input is entered as string. The output should be a variable of type long.
            //Do not use the built-in .NET functionality.

            Console.WriteLine("Enter you hexadecimal value: ");
            string hex = Console.ReadLine();
            long dec = 0;
            long power = 1;

            for (int i = hex.Length - 1; i >= 0; i--)
            {
                int num;
                switch (hex[i])
                {
                    case 'A':
                        num = 10;
                        break;
                    case 'B':
                        num = 11;
                        break;
                    case 'C':
                        num = 12;
                        break;
                    case 'D': 
                        num = 13;
                        break;
                    case 'E': 
                        num = 14;
                        break;
                    case 'F': 
                        num = 15; 
                        break;
                    default: 
                        num = (int)hex[i] - 48;
                        break;
                }
                dec += num * power;
                power *= 16;
            }
            Console.WriteLine("Your decimal number is: {0}",dec);
        }
    }
}
