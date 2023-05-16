using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                int leftSum = 0; //left
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += inputNumbers[j];
                }
                for (int j = i + 1; j < inputNumbers.Length; j++)
                {
                    rightSum += inputNumbers[j];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
