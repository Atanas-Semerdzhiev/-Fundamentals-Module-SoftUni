using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToList();


            string curentComand;
            while ((curentComand = Console.ReadLine()) != "End")
            {
                string[] comand = curentComand.Split();
                string firstComand = comand[0];
                int element = 0;
                if (firstComand == "Add")
                {
                    element = int.Parse(comand[1]);
                    numbers.Add(element);
                }
                else if (firstComand == "Insert")
                {
                    element = int.Parse(comand[1]);
                    int index = int.Parse(comand[2]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, element);
                }
                else if (firstComand == "Remove")
                {

                    int index = int.Parse(comand[1]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
                else if (firstComand == "Shift")
                {
                    string second = comand[1];
                    int integer = int.Parse(comand[2]);
                    if (second == "right")
                    {

                        while (integer > 0)
                        {
                            int lastInts = numbers[numbers.Count - 1];
                            numbers.Insert(0, lastInts);
                            numbers.RemoveAt(numbers.Count - 1);
                            integer--;
                        }
                    }
                    else if (second == "left")
                    {

                        while (integer > 0)
                        {
                            int furstInts = numbers[0];
                            numbers.Remove(numbers[0]);
                            numbers.Add(furstInts);

                            integer--;
                        }
                    }


                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
