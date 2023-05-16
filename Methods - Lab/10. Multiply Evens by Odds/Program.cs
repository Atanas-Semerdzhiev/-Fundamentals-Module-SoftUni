using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputInteger = Console.ReadLine();
            int usedInteger = Math.Abs(int.Parse(inputInteger));


            int oddResult = GetSumOfOddDigits(usedInteger, inputInteger);
            int evenResult = GetSumOfEvenDigits(usedInteger, inputInteger);
            int sumResult = GetMultipleOfEvenAndOdds(oddResult, evenResult);
            Console.WriteLine(sumResult);
        }



        private static int GetSumOfOddDigits(int usedInteger, string inputInteger)
        {
            int oddResult = 0;
            for (int i = 0; i < inputInteger.Length; i++)
            {
                int curentInteger = usedInteger % 10;
                if (usedInteger % 2 != 0)
                {
                    oddResult += curentInteger;
                }
                usedInteger = usedInteger / 10;
            }
            return oddResult;
        }


        private static int GetSumOfEvenDigits(int usedInteger, string inputInteger)
        {

            int evenResult = 0;
            for (int i = 0; i < inputInteger.Length; i++)
            {
                int curentInteger = usedInteger % 10;
                if (usedInteger % 2 == 0)
                {
                    evenResult += curentInteger;
                }
                usedInteger = usedInteger / 10;
            }
            return evenResult;
        }
        private static int GetMultipleOfEvenAndOdds(int evenResult, int oddResult)
        {
            int sumResult = evenResult * oddResult;
            return sumResult;
        }
    }
}
