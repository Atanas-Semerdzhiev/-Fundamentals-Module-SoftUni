using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> word = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .ToList();

            List<string> outputList = new List<string>();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] comArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string comType = comArg[0];

                if (comType == "merge")
                {
                    int startIndex = int.Parse(comArg[1]);
                    int endIndex = int.Parse(comArg[2]);
                    FixInvalidIndex(word, ref startIndex, ref endIndex);
                    MergeWords(word, startIndex, endIndex);
                }
                else if (comType == "divide")
                {
                    int index = int.Parse(comArg[1]);
                    int partition = int.Parse(comArg[2]);
                    string curentWord = word[index];
                    int substringLenght = curentWord.Length / partition;
                    int lastSubStringLenght = curentWord.Length - ((partition - 1) * substringLenght);
                    List<string> particionList = new List<string>();
                    for (int i = 0; i < partition; i++)
                    {
                        int desiredLength = substringLenght;
                        if (i == partition - 1)
                        {
                            desiredLength = lastSubStringLenght;
                        }
                        char[] newPartitionsArr = curentWord
                            .Skip(i * substringLenght)
                            .Take(desiredLength)
                            .ToArray();
                        string newPartition = String.Join("", newPartitionsArr);
                        particionList.Add(newPartition);
                    }
                    word.RemoveAt(index);
                    word.InsertRange(index, particionList);
                }
            }
            Console.WriteLine(string.Join(" ", word));
        }
        static void FixInvalidIndex(List<string> word, ref int startIndex, ref int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (startIndex >= word.Count - 1)
            {
                startIndex = word.Count - 1;
            }
            if (endIndex <= 0)
            {
                endIndex = 0;
            }
            if (endIndex > word.Count - 1)
            {
                endIndex = word.Count - 1;
            }
        }
        static void MergeWords(List<string> word, int startIndex, int endIndex)
        {
            string mergeWord = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                mergeWord += word[startIndex];
                word.RemoveAt(startIndex);
            }
            word.Insert(startIndex, mergeWord);
        }
    }
}
