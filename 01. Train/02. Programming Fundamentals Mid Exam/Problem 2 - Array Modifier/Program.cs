using System;
using System.Linq;

namespace Problem_2___Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] startArray = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries )
                .Select(int.Parse)
                .ToArray();
            string inputCommand;
            while ((inputCommand = Console.ReadLine())!="end")
            {
                string[] command = inputCommand.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string commandArg = command[0];
                if(commandArg == "swap")
                {
                    int firstIndex = int.Parse(command[1]);
                    int secondIndex =int.Parse(command[2]);
                    int waiting = startArray[firstIndex];
                    startArray[firstIndex] = startArray[secondIndex];
                    startArray[secondIndex] = waiting;
                }
                else if(commandArg == "multiply")
                {
                    int firstIndex= int.Parse(command[1]);
                    int secondIndex= int.Parse(command[2]);
                    int sumElement = startArray[firstIndex]* startArray[secondIndex];
                    startArray[firstIndex] = sumElement;
                }
                else if (commandArg == "decrease")
                {
                    for (int i = 0; i < startArray.Length; i++)
                    {
                        startArray[i] -= 1;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", startArray));
        }
    }
}
