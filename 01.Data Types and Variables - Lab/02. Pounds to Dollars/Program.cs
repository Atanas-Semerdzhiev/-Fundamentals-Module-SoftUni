using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            double dolars = pounds * 1.310;
            Console.WriteLine($"{dolars:f3}");
        }
    }
}
