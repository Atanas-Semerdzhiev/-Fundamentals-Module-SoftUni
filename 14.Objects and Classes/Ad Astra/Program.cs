using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> pirateShip = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();
            List<int> warShip = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();
            int maximumHealth = int.Parse(Console.ReadLine());
            string play;
            bool isFael = false;
            while ((play = Console.ReadLine()) != "Retire")
            {
                List<string> command = play.Split(" ").ToList();
                string curentCommand = command[0];
                if(curentCommand== "Fire")
                {
                    int index = int.Parse(command[1]);
                    int damage = int.Parse(command[2]);
                    if(index >= 0 && index < warShip.Count)
                    {
                        warShip[index] -= damage;
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            isFael = true;
                            break;
                        }
                    }
                }
                else if (curentCommand == "Defend")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    int damage = int.Parse(command[3]);
                    if(startIndex >= 0 && startIndex < pirateShip.Count
                        &&endIndex>=0 && endIndex<pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                isFael = true;
                                break;
                            }
                        }
                        if (isFael)
                        {
                            break;
                        }
                    }
                }
                else if(curentCommand == "Repair")
                {
                    int index = int.Parse(command[1]);
                    int health = int.Parse(command[2]);
                    if (index >= 0 &&index < pirateShip.Count)
                    {
                        pirateShip[index] += health;
                        if (pirateShip[index] > maximumHealth)
                        {
                            pirateShip[index] = maximumHealth;
                        }
                    }
                }
                else if ((curentCommand == "Status"))
                {
                    double percent = maximumHealth * 0.2;
                    int count = 0;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < percent)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }
            
            }
            int sumStatusPirateShip = 0;
            for (int i = 0;i < pirateShip.Count; i++)
            {
                sumStatusPirateShip += pirateShip[i];
            }
            int sumStatusWarship = 0;
            for(int i = 0;i< warShip.Count ; i++)
            {
                sumStatusWarship += warShip[i];
            }
            if(!isFael)
            {
                Console.WriteLine($"Pirate ship status: {sumStatusPirateShip}");
                Console.WriteLine($"Warship status: { sumStatusWarship}");
            }

        }
    }
}
