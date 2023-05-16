using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int furstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int thirdDigit = int.Parse(Console.ReadLine());

            int sumResult = SumResult(furstDigit, secondDigit);
            int subtractsResult = SubtractsResult(sumResult, thirdDigit);
            Console.WriteLine(subtractsResult);


        }



        private static int SumResult(int furstDigit, int secondDigit)
        {
            int result = furstDigit + secondDigit;
            return result;
        }
        private static int SubtractsResult(int sumResult, int thirdDigit)
        {
            int result = sumResult - thirdDigit;
            return result;
        }
    }
}
