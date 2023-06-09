using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                int curentNumber = i;
                bool sum = SumOfDigits(curentNumber);
                bool Odd = OddDigit(curentNumber);
                if (sum == true && Odd == true)
                {
                    Console.WriteLine(curentNumber);
                }

            }
        }

        private static bool SumOfDigits(int curentNumber)
        {
            string size = curentNumber.ToString();
            int sum = 0;
            for (int i = 0; i < size.Length; i++)
            {
                sum += curentNumber % 10;
                curentNumber /= 10;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
        static bool OddDigit(int curentNumber)
        {
            string size = curentNumber.ToString();
            int lastInts = 0;
            for (int i = 0; i < size.Length; i++)
            {
                lastInts += curentNumber % 10;
                if (lastInts % 2 != 0)
                {
                    return true;
                }
                curentNumber /= 10;
            }
            return false;
        }
    }
}
