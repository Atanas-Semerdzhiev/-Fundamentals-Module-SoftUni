using System;
using System.Collections.Generic;
using System.Linq;

namespace Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> startGame = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string plaey;
            int movesCounter = 0;
            bool winer = false;
            while ((plaey = Console.ReadLine()) != "end")
            {
                movesCounter++;
                string[] command = plaey.Split().ToArray();
                int firstTry = int.Parse(command[0]);
                int secondTry = int.Parse(command[1]);
                if (firstTry == secondTry || firstTry >= startGame.Count || firstTry < 0
                    || secondTry >= startGame.Count || secondTry < 0)
                {
                    startGame.Insert(startGame.Count / 2, "-" + movesCounter.ToString() + 'a');
                    startGame.Insert(startGame.Count / 2, "-" + movesCounter.ToString() + 'a');
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }
                if (startGame[firstTry] == startGame[secondTry])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {startGame[firstTry]}!");
                    if(firstTry < secondTry)
                    {
                        startGame.RemoveAt(secondTry);
                        startGame.RemoveAt(firstTry);
                    }
                    else if (firstTry > secondTry) 
                    {
                        startGame.RemoveAt(firstTry);
                        startGame.RemoveAt(secondTry);
                    }
                   
                }
                else if (startGame[firstTry] != startGame[secondTry])
                {
                    Console.WriteLine("Try again!");
                }
                if (startGame.Count == 0)
                {
                    winer = true;
                    break;
                }
            }
            if (winer)
            {
                Console.WriteLine($"You have won in {movesCounter} turns!");
            }
            else
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(String.Join(" ", startGame));
            }

        }
    }
}