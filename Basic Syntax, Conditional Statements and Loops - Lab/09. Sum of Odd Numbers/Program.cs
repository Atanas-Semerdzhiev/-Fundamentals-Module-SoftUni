﻿using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endIndex = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < endIndex * 2; i += 2)
            {
                Console.WriteLine(i);
                sum += i;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
