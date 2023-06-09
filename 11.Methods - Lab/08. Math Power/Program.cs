using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double integers = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = ColculetResult(integers, power);
            Console.WriteLine(result);
        }

        private static double ColculetResult(double integers, double power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= integers;
            }
            return result;
        }
    }
}
