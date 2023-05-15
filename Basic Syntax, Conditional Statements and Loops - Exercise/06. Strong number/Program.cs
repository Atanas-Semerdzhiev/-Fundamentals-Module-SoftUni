using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputInteger = int.Parse(Console.ReadLine());
            int finalSum = 0;
            int copiInput = inputInteger;
            while (inputInteger != 0)
            {
                int curentInts = inputInteger % 10;
                inputInteger /= 10;
                int sum = 1;
                for (int j = 1; j <= curentInts; j++)
                {
                    sum *= j;
                }
                finalSum += sum;

            }
            if (finalSum == copiInput)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
