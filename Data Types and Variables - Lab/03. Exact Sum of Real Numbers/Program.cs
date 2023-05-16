using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberLine = int.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 0; i < numberLine; i++)
            {
                decimal curentDigits = decimal.Parse(Console.ReadLine());
                sum += curentDigits;
            }
            Console.WriteLine($"{sum}");
        }
    }
}
