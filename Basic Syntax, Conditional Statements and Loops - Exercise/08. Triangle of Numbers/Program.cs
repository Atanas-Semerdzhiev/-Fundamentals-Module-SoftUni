using System;

namespace _08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int columns = 1; columns <= row; columns++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
