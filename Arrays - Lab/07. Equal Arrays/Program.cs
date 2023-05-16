using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] furstArray = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToArray();
            int[] secondArray = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            int totalsum = 0;
            bool difference = false;
            for (int i = 0; i < furstArray.Length; i++)
            {
                if (furstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    difference = true;
                    break;
                }
                totalsum += furstArray[i];
            }
            if (difference == false)
            {
                Console.WriteLine($"Arrays are identical. Sum: {totalsum}");
            }
        }
    }
}
