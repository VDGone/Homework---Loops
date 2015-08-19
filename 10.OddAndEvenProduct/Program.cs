using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given n integers (given in a single line, separated by a space).
            //Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
            //Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

            Console.Write("Enter numbers separeted by space: ");
            string inputNumbers = Console.ReadLine();
            string[] numbers = inputNumbers.Split(new char[] {' '});
            int odd = 1;
            int even = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int num = int.Parse(numbers[i]);
                if (i % 2 == 0)
                {
                    even *= num;
                }
                else if (i % 2 != 0)
                {
                    odd *= num;
                }
            }
            if (even == odd)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", even);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", even);
                Console.WriteLine("even_product = {0}", odd);
            }
        }
    }
}
