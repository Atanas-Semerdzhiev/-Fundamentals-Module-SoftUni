using System;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
             .Split()
             .Select(int.Parse)                //1 2 3 4 5 ;
             .ToArray();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                bool isTop = true;
                for (int j = i + 1; j < inputNumbers.Length; j++)
                {
                    if (inputNumbers[i] <= inputNumbers[j])
                    {
                        isTop = false;
                        break;
                    }
                }
                if (isTop == true)
                {
                    Console.Write($"{inputNumbers[i]} ");
                }
            }
        }
    }
}
