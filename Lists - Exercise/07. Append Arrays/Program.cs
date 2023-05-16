using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> outputList = new List<string>();
            for (int i = inputList.Count - 1; i >= 0; i--)
            {
                string[] stringtArray = inputList[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < stringtArray.Length; j++)
                {
                    outputList.Add(stringtArray[j]);
                }
            }
            foreach (string ints in outputList)
            {
                Console.Write(ints + " ");
            }
        }
    }
}
