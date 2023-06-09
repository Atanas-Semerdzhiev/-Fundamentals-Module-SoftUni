using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string gameName = Console.ReadLine();
            double balance = 0;
            double spentMoney = 0;
            while (gameName != "Game Time")
            {
                double price = 0;

                if (gameName == "OutFall 4")
                {
                    price = 39.99;
                }
                else if (gameName == "CS: OG")
                {
                    price = 15.99;
                }
                else if (gameName == "Zplinter Zell")
                {
                    price = 19.99;
                }
                else if (gameName == "Honored 2")
                {
                    price = 59.99;
                }
                else if (gameName == "RoverWatch")
                {
                    price = 29.99;
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

           

                if (budget != 0)
                {
                    if (budget < price)
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                    else
                    {
                        balance += price;
                        budget -= price;

                        Console.WriteLine($"Bought {gameName}");
                        //Console.WriteLine($"Total spent: ${balance}. Remaining: ${budget:f2}");
                    }
                }

                if (budget == 0)
                {
                    Console.WriteLine($"Out of money!");
                    break;
                }
                gameName = Console.ReadLine();
            }
            if (gameName == "Game Time")
            {
                Console.WriteLine($"Total spent: ${balance:f2}. Remaining: ${budget:f2}");
            }
        }
    }
}
