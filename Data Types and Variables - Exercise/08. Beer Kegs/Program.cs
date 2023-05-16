using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberKegs = int.Parse(Console.ReadLine());
            double maxValue = double.MinValue;
            string curentName = "";
            for (int i = 0; i < numberKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double formula = 3.14 * radius * radius * height;
                if (formula > maxValue)
                {
                    maxValue = formula;
                    curentName = model;
                }
            }
            Console.WriteLine(curentName);
        }
    }
}
