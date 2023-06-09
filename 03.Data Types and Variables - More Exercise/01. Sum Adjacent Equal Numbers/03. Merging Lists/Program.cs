using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputArray1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> inputArray2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();

            int index = Math.Min(inputArray1.Count, inputArray2.Count);
            for (int i = 0; i < index; i++)
            {
                result.Add(inputArray1[i]);
                result.Add(inputArray2[i]);
            }
            if (inputArray1.Count > inputArray2.Count)
            {
                for (int i = index; i < inputArray1.Count; i++)
                {
                    result.Add(inputArray1[i]);
                }
            }
            else if (inputArray2.Count > inputArray1.Count)
            {
                for (int i = index; i < inputArray2.Count; i++)
                {
                    result.Add(inputArray2[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result.ToArray()));
        }
    }
}
