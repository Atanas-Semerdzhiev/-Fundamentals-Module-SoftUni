using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberLine = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberLine; i++)
            {
                if (i == 5 || i == 7)
                {
                    Console.WriteLine($"{i} -> True");
                }
                if (i > 10)
                {
                    int furstInteger = i % 10;
                    int secontInteger = i / 10;
                    int sum = furstInteger + secontInteger;
                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        Console.WriteLine($"{i} -> True");
                        continue;
                    }
                }
                if (i > 100)
                {
                    int furstInteger = i % 10;
                    int secontInteger = i / 10;
                    int thirdInteger = i % 100 / 10;
                    int sum = furstInteger + secontInteger + thirdInteger;
                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        Console.WriteLine($"{i} -> True");
                    }
                }
                if (i != 5 && i != 7)
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
