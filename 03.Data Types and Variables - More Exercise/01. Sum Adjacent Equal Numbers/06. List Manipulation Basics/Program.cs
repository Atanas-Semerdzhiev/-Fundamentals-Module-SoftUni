using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string comand;
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] curendComand = comand.Split();
            string firstComand = curendComand[0];
            if (firstComand == "Add")
            {
                int numb = int.Parse(curendComand[1]);
                numbers.Add(numb);
            }
            else if (firstComand == "Remove")
            {
                int numb = int.Parse(curendComand[1]);
                numbers.Remove(numb);
            }
            else if (firstComand == "RemoveAt")
            {
                int index = int.Parse(curendComand[1]);
                numbers.RemoveAt(index);
            }
            else if (firstComand == "Insert")
            {
                int numb = int.Parse(curendComand[1]);
                int index = int.Parse(curendComand[2]);
                numbers.Insert(index, numb);
            }

        }


        Console.WriteLine(string.Join(" ", numbers.ToArray()));
        }
    }
}
