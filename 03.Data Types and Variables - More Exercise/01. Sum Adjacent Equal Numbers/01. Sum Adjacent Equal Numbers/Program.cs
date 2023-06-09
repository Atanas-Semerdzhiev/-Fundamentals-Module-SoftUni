using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> inputArray = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            for (int i = 0; i < inputArray.Count - 1; i++)
            {


                if (inputArray[i] == inputArray[i + 1])
                {
                    inputArray[i] = inputArray[i] + inputArray[i + 1];
                    inputArray.RemoveAt(i + 1);


                    i = -1;
                }


            }
            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}
