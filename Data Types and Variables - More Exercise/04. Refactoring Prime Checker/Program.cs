using System;

namespace _04._Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputInts = int.Parse(Console.ReadLine());
            for (int i = 2; i <= inputInts; i++)
            {
                string odd = "true";
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        odd = "false";
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, odd);
            }
        }
    }
}
