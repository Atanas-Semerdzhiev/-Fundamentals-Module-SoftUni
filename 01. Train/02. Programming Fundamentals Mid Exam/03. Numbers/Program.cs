using System;
using System.Collections.Immutable;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            double arraySum = 0;
            bool print = false;
            for (int i = 0; i < inputArray.Length; i++)
            {
                arraySum += inputArray[i];
            }
            double averageIteger = arraySum / inputArray.Length;                         
            int counter = 0;
            for (int i = 0;i < inputArray.Length; i++)
            {
                if (averageIteger < inputArray[i])
                {
                  //  Console.Write(inputArray[i] + " ");
                    print = true;
                    counter++;
                    
                }
               
                if (counter == 5)
                {
                    break;
                }
            }
            if (print == false)
            {
                Console.WriteLine("No");
            }
            else if (print)
            {
                Array.Sort(inputArray);
                Array.Reverse(inputArray);
                for (int i = 0;i< counter ; i++)
                {
                    Console.Write(inputArray[i]+" ");
                }

            }
        }
    }
}
