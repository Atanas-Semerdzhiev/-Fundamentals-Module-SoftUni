using System;

namespace _03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double numberLine = 0.0;
            double numberLine2 = 0.0;
            while (true)
            {


                numberLine = double.Parse(Console.ReadLine());
                numberLine2 = double.Parse(Console.ReadLine());
                bool isEqual = Math.Abs(numberLine - numberLine2) < eps;

                if (isEqual)
                {
                    Console.WriteLine("True");
                    return;
                }
                else
                {
                    Console.WriteLine("False");
                    return;
                }

            }
        }
    }
}
