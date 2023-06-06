using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PositivOrNegativNumber(number);
        }

         static void PositivOrNegativNumber(int number)
        {
            if(number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if(number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number is zero");
            }
        }
    }
}
