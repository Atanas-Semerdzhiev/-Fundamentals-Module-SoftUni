using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse).ToArray();//10 20 30 40 50 ;

            int rotation = int.Parse(Console.ReadLine());
            for (int j = 0; j < rotation; j++)
            {
                int furstElement = inputNumbers[0];

                for (int i = 0; i < inputNumbers.Length - 1; i++)
                {
                    inputNumbers[i] = inputNumbers[i + 1];


                }
                inputNumbers[inputNumbers.Length - 1] = furstElement;
            }

            Console.WriteLine(string.Join(" ", inputNumbers));
        }
    }
}
