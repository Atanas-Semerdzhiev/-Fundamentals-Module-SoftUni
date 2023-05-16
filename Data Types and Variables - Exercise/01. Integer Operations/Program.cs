using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int furstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());
            int fourthInteger = int.Parse(Console.ReadLine());
            int furstResult = furstInteger + secondInteger;
            int secondResult = furstResult / thirdInteger;
            double thirdResult = secondResult * fourthInteger;
            Console.WriteLine($"{thirdResult}");
        }
    }
}
