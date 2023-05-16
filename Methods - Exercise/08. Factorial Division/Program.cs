using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double furstDigit1 = double.Parse(Console.ReadLine());
            double secondDigit2 = int.Parse(Console.ReadLine());
            double furstDigit = Math.Abs(furstDigit1);
            double secondDigit = Math.Abs(secondDigit2);
            double furstResult = CalculateFacturial(furstDigit);
            double secondResult = CalculateFacturial2(secondDigit);
            double divideResult = DivideResult(furstResult, secondResult);
            Console.WriteLine($"{divideResult:f2}");

        }


        private static double CalculateFacturial(double furstDigit)
        {
            double result = 1;
            for (int i = 1; i <= furstDigit; i++)
            {
                result *= i;
            }
            return result;
        }
        private static double CalculateFacturial2(double secondDigit)
        {
            double result = 1;
            for (int i = 1; i <= secondDigit; i++)
            {
                result *= i;
            }
            return result;
        }
        private static double DivideResult(double furstResult, double secondResult)
        {
            double result = furstResult / secondResult;
            return result;
        }
    }
}
