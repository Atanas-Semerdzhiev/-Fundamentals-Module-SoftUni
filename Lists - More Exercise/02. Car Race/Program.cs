using System;
using System.Linq;

namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rute = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double firstPlayer = 0;
            double secondPlayer = 0;
            for (int i = 0; i < rute.Length / 2; i++)
            {
                if (rute[i] == 0)
                {
                    firstPlayer *= 0.8;
                }
                if (rute[rute.Length - 1 - i] == 0)
                {
                    secondPlayer *= 0.8;
                }
                firstPlayer += rute[i];
                secondPlayer += rute[rute.Length - 1 - i];
            }
            if (firstPlayer < secondPlayer)
            {
                Console.WriteLine($"The winner is left with total time: {firstPlayer}");
            }
            else if (secondPlayer < firstPlayer)
            {
                Console.WriteLine($"The winner is right with total time: {secondPlayer}");
            }
        }
    }
}
