using System;

namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int furstNum = int.Parse(Console.ReadLine());
            int secondNUm = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            if (furstNum == 0 || secondNUm == 0 || thirdNum == 0)
            {
                Console.WriteLine("zero");
            }
            else if (furstNum < 0 || secondNUm < 0 || thirdNum < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
