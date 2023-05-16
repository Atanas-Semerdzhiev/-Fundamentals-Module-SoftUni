using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberKegs = int.Parse(Console.ReadLine());
            int maxValue = 255;
            int sum = 0;
            for (int i = 0; i < numberKegs; i++)
            {

                int litersWoater = int.Parse(Console.ReadLine());

                if (maxValue >= litersWoater)
                {
                    maxValue -= litersWoater;
                    sum += litersWoater;
                }
                else if (maxValue < litersWoater)
                {
                    Console.WriteLine($"Insufficient capacity!");
                }
            }
            Console.WriteLine(sum);
        }
    }
}
