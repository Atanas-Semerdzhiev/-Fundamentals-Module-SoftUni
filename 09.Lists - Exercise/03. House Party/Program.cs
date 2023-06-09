using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArg[0];
                // is coming
                if (cmdArg.Length == 3)
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    guestList.Add(name);
                }
                else if (cmdArg.Length == 4)
                {
                    // is not coming
                    if (!guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    guestList.Remove(name);
                }
            }
            PrintGuestList(guestList);

        }
        static void PrintGuestList(List<string> guestList)
        {
            foreach (string guest in guestList)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
