using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputInteger = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int magicSum = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputInteger.Length-1; i++)
            {
                for (int j = i+1; j < inputInteger.Length; j++)
                { 
                    if ((inputInteger[i] + inputInteger[j]) == magicSum)
                    {
                        Console.WriteLine($"{inputInteger[i]} {inputInteger[j]}");
                    }
                }
            }
        }
    }
}
