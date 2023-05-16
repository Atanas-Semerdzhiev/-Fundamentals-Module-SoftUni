using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] furstLine = Console.ReadLine()
                .Split(" ");
            string[] secondLine = Console.ReadLine()
                .Split();
            for (int i = 0; i < secondLine.Length; i++)
            {
                string secondElement = secondLine[0 + i];
                for (int j = 0; j < furstLine.Length; j++)
                {
                    string furstElement = furstLine[0 + j];

                    if (furstElement == secondElement)
                    {
                        Console.Write($"{secondElement} ");
                    }
                }
            }
        }
    }
}
