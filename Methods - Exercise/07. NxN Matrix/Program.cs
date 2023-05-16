using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {

                int inputInteger = int.Parse(Console.ReadLine());
                PrintMatrix(inputInteger);

            }
            static void PrintMatrix(int inputInteger)
            {
                for (int i = 0; i < inputInteger; i++)
                {
                    for (int j = 0; j < inputInteger; j++)
                    {
                        Console.Write($"{inputInteger} ");
                    }
                    Console.WriteLine();
                }
            }
        }  
    }
}
