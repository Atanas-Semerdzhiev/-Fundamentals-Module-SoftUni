using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = ColculetResult(a, b);
            Console.WriteLine(result);
        }

        private static double ColculetResult(double a, double b)
        {
            double result = a * b;
            return result;
        }
    }
}
