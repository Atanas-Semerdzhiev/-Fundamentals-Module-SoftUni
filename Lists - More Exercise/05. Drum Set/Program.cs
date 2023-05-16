using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            List<int> drumCondition = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> drumConCopy = new List<int>();
            for (int i = 0; i < drumCondition.Count; i++)
            {
                drumConCopy.Add(drumCondition[i]);
            }
            string command;
            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                // 55 111 3 5 8 50
                int power = int.Parse(command);
                for (int i = 0; i < drumConCopy.Count; i++)
                {

                    drumConCopy[i] -= power;

                    if (drumConCopy[i] <= 0)
                    {
                        double price = drumCondition[i] * 3;
                        if (budget >= price)
                        {
                            drumConCopy[i] = drumCondition[i];
                            budget -= price;
                        }
                        else
                        {
                            drumConCopy.RemoveAt(i);
                            drumCondition.RemoveAt(i);
                            i--;
                        }

                    }
                }

            }
            Console.WriteLine(string.Join(" ", drumConCopy));
            Console.WriteLine($"Gabsy has {budget:f2}lv.");
        }
    }
}
