using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondLineine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> result = new List<int>();
            int startIndexToList = 0;
            int endIndexToList = 0;
            int endIndex = Math.Min(firstLine.Length, secondLineine.Length);
            for (int i = 0; i < endIndex; i++)
            {
                result.Add(firstLine[i]);
                result.Add(secondLineine[secondLineine.Length - 1 - i]);
            }


            if (firstLine.Length > secondLineine.Length)
            {
                startIndexToList = firstLine[firstLine.Length - 1];
                endIndexToList = firstLine[firstLine.Length - 2];

            }
            if (secondLineine.Length > firstLine.Length)
            {
                startIndexToList = secondLineine[0];
                endIndexToList = secondLineine[1];
            }
            List<int> finalList = new List<int>();
            if (startIndexToList < endIndexToList)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] > startIndexToList && result[i] < endIndexToList)
                    {
                        finalList.Add(result[i]);
                    }
                }
            }
            else if (startIndexToList > endIndexToList)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] > endIndexToList && result[i] < startIndexToList)
                    {
                        finalList.Add(result[i]);
                    }
                }
            }
            finalList.Sort();
            Console.WriteLine(string.Join(" ", finalList.ToArray()));
        }
    }
}
