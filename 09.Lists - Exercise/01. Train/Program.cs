using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());
            bool isChenge = false;
            string curentComand;
            while ((curentComand = Console.ReadLine()) != "end")
            {
                string[] comand = curentComand.Split();
                string firstComand = comand[0];
                if (firstComand == "Add")
                {
                    int secondComand = int.Parse(comand[1]);
                    wagons.Add(secondComand);
                }
                else
                {
                    int pasangers = int.Parse(comand[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int curentWagons = wagons[i];
                        if (pasangers + curentWagons <= capacity)
                        {
                            wagons[i] = curentWagons + pasangers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
