using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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
            bool isChenge = false;
            string comand;
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] curendComand = comand.Split();
                string firstComand = curendComand[0];
                if (firstComand == "Add")
                {
                    int numb = int.Parse(curendComand[1]);
                    numbers.Add(numb);
                    isChenge = true;
                }
                else if (firstComand == "Remove")
                {
                    int numb = int.Parse(curendComand[1]);
                    numbers.Remove(numb);
                    isChenge = true;
                }
                else if (firstComand == "RemoveAt")
                {
                    int index = int.Parse(curendComand[1]);
                    numbers.RemoveAt(index);
                    isChenge = true;
                }
                else if (firstComand == "Insert")
                {
                    int numb = int.Parse(curendComand[1]);
                    int index = int.Parse(curendComand[2]);
                    numbers.Insert(index, numb);
                    isChenge = true;
                }
                else if (firstComand == "Contains")
                {
                    int num = int.Parse(curendComand[1]);
                    if (numbers.Contains(num))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (firstComand == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (firstComand == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (firstComand == "GetSum")
                {
                    Console.WriteLine(string.Join(" ", numbers.Sum()));
                }
                else if (firstComand == "Filter")
                {
                    string condition = curendComand[1];
                    int ints = int.Parse(curendComand[2]);
                    if (condition == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < ints)));
                    }
                    else if (condition == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= ints)));
                    }
                    else if (condition == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > ints)));
                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= ints)));
                    }

                }

            }
            if (isChenge)
            {
                Console.WriteLine(string.Join(" ", numbers.ToArray()));
            }
        }
    }
}
