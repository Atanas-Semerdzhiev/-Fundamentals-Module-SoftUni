using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bayFood = Console.ReadLine()
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string  command;
            int counter = 0;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                counter++;
                string[] newCommand = command.Split().ToArray();
                string commandArg = newCommand[0];
                if (commandArg == "Urgent")
                {
                    string item = newCommand[1];
                    if(bayFood.Contains(item))
                    {
                        continue;
                    }
                    bayFood.Insert(0, item);
                }
                else if (commandArg == "Unnecessary")
                {
                    string item = newCommand[1];
                    if (bayFood.Contains(item))
                    {
                        bayFood.Remove(item);
                    }
                    continue;
                }
                else if(commandArg == "Correct")
                {
                    string oldItem = newCommand[1];
                    string newItem = newCommand[2];
                    if (bayFood.Contains(oldItem))
                    {
                        for (int i = 0; i < bayFood.Count; i++)
                        {
                            if (bayFood[i] == oldItem)
                            {
                                bayFood[i] = newItem;
                            }
                        }
                    }
                }
                else if( commandArg == "Rearrange")
                {
                    string item = newCommand[1];
                    if (bayFood.Contains(item))
                    {
                        bayFood.Remove(item) ;
                        bayFood.Add(item);
                    }
                }
            }
           
            
                Console.WriteLine(string.Join(", ", bayFood));
            
           
        }
    }
}
