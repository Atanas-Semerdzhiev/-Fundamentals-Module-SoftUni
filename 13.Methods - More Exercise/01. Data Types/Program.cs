using System;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            string input = Console.ReadLine();
            if (value == "int")
            {
                double result = WorkDigits(value, input);
                Console.WriteLine(result);
            }
            else if (value == "real")
            {
                double result = WorkDigits(value, input);
                Console.WriteLine($"{result:f2}");
            }
            else
            {
                Console.WriteLine($"${input}$");
            }
        }
        static double WorkDigits(string value, string input)
        {
            double curentNumber = double.Parse(input);
            double result = 0;
            if (value == "int")
            {
                result = curentNumber * 2;
            }
            else if (value == "real")
            {
                result = curentNumber * 1.5;
            }
            return result;
        }
    }
}
