using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()   // "10 20 30 "
                  .Split()                           //""10" "20" "30"
                  .Select(int.Parse)                // 10 20 30 
                  .ToArray();

            for (int i = 0; i < inputNumbers.Length - 1; i++)
            {
                // 10 20 30
                for (int j = 0; j < inputNumbers.Length - 1 - i; j++)
                {
                    inputNumbers[j] = inputNumbers[j] + inputNumbers[j + 1];
                }

            }
            Console.WriteLine(inputNumbers[0]);
        }
    }
}
