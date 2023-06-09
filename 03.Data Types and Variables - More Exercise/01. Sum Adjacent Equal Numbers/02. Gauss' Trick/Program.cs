using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputArray = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < inputArray.Count / 2; i++)
            {

                int curentSum = inputArray[i] + inputArray[inputArray.Count - 1 - i];
                result.Add(curentSum);


            }
            if (inputArray.Count % 2 != 0)
            {
                result.Add(inputArray[inputArray.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", result.ToArray()));
        }
    }
}
