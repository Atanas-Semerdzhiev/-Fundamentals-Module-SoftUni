using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] intsArray = Console.ReadLine()
             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
             .Select(double.Parse)
             .ToArray();
       
            for (int i = 0; i < intsArray.Length; i++)
            {
               
                Console.WriteLine($"{intsArray[i]} => {Math.Round(intsArray[i], MidpointRounding.AwayFromZero)}");


            }
        }
    }
}
