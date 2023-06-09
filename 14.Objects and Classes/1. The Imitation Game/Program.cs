using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> message = new List<char>();
            
            for (int i = 0; i < input.Length; i++)
            {
                 char a = input[i];
                message.Add(a);
            }
            string command;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] commandArguments = command.Split("|");
                string doThis = commandArguments[0];
                if (doThis == "Move")
                {
                    int numbersOfCharcter = int.Parse(commandArguments[1]);
                    int counter = 0;
                    while (counter < numbersOfCharcter)
                    {
                        counter++;
                        message.Add(message[0]);
                        message.Remove(message[0]);
                    }

                }
                else if (doThis == "Insert")
                {
                    int index = int.Parse(commandArguments[1]);
                    string startValue = commandArguments[2];
                    for (int i = 0; i < startValue.Length; i++)
                    {
                        char value = startValue[i];
                        message.Insert((index+i), value);
                    }
                   
                    

                }
                else if(doThis == "ChangeAll")
                {
                    char substring = char.Parse( commandArguments[1]);
                    char replacement = char.Parse(commandArguments[2]);
                    for (int i = 0;i<message.Count;i++)
                    {
                        if (message[i] == substring)
                        {
                            message[i] = replacement;
                        }
                    }
                }
            }
            string finalMessage ;

            Console.WriteLine($"The decrypted message is: {String.Join("", message)}");
        }
    }
}
