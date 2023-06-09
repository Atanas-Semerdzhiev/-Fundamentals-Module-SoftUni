using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string orderes = Console.ReadLine();
            int intsOrderes = int.Parse(Console.ReadLine());
            if (orderes == "coffee")
            {
                double price = 1.50;
                ColculetSum(intsOrderes, price);

            }
            else if (orderes == "water")
            {
                double price = 1.00;
                ColculetSum(intsOrderes, price);
            }
            else if (orderes == "coke")
            {
                double price = 1.40;
                ColculetSum(intsOrderes, price);
            }
            else if (orderes == "snacks")
            {
                double price = 2.00;
                ColculetSum(intsOrderes, price);
            }
        }

        private static void ColculetSum(int intsOrderes, double price)
        {
            double result = intsOrderes * price;
            Console.WriteLine($"{result:f2}");
        }
    }
}
