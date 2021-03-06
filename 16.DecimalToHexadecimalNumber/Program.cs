﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DecimalToHexadecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using loops write a program that converts an integer number to its hexadecimal representation.
            //The input is entered as long. The output should be a variable of type string.
            //Do not use the built-in .NET functionality.

            Console.WriteLine("Enter your decimal number: ");
            long dec = long.Parse(Console.ReadLine());
            string hex = "";

            if (dec == 0)
            {
                hex = "0";
            }
            else
            {
                while (dec > 0)
                {
                    long remain = dec % 16;
                    dec /= 16;
                    switch (remain)
                    {
                        case 10: 
                            hex = "A" + hex;
                            break;
                        case 11: 
                            hex = "B" + hex; 
                            break;
                        case 12: 
                            hex = "C" + hex; 
                            break;
                        case 13: 
                            hex = "D" + hex; 
                            break;
                        case 14:
                            hex = "E" + hex; 
                            break;
                        case 15: 
                            hex = "F" + hex; 
                            break;
                        default: 
                            hex = remain + hex; 
                            break;
                    }
                }
            }
            Console.WriteLine("Your hexadecimal number is {0}", hex);
        }
    }
}
