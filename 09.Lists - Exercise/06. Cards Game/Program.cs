using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayer = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToList();
            int indexForPlaye = Math.Min(firstPlayer.Count, secondPlayer.Count);
            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {


                for (int i = 0; i < indexForPlaye; i++)
                {
                    if (firstPlayer[i] == secondPlayer[i])
                    {
                        firstPlayer.RemoveAt(i);
                        secondPlayer.RemoveAt(i);
                    }
                    else if (firstPlayer[i] > secondPlayer[i])
                    {
                        firstPlayer.Insert(firstPlayer.Count, firstPlayer[i]);
                        firstPlayer.RemoveAt(i);
                        firstPlayer.Add(secondPlayer[i]);
                        secondPlayer.RemoveAt(i);
                    }
                    else if (secondPlayer[i] > firstPlayer[i])
                    {
                        secondPlayer.Insert(secondPlayer.Count, secondPlayer[i]);
                        secondPlayer.RemoveAt(i);
                        secondPlayer.Add(firstPlayer[i]);
                        firstPlayer.RemoveAt(i);
                    }
                    i--;
                    indexForPlaye = Math.Min(firstPlayer.Count, secondPlayer.Count);
                }

            }
            if (firstPlayer.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else if (secondPlayer.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
    }
}
