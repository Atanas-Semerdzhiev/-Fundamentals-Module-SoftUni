using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
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
            while ((curentComand = Console.ReadLine()) != "end")
            {
                string[] comand = curentComand.Split();
                string firstComand = comand[0];
                if (firstComand == "Delete")
                {
                    int element = int.Parse(comand[1]);
                    numbers.RemoveAll(x => x == element);
                }
                else if (firstComand == "Insert")
                {
                    int element = int.Parse(comand[1]);
                    int index = int.Parse(comand[2]);
                    numbers.Insert(index, element);
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
