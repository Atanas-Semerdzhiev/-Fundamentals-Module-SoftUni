using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            int maxPeople = int.Parse(Console.ReadLine());
            int result1 = peopleNumber % maxPeople;
            int result2 = 0;
            if (result1 != 0)
            {
                result2 = peopleNumber / maxPeople + 1;
            }
            else
            {
                result2 = peopleNumber / maxPeople;
            }
            Console.WriteLine(result2);
        }
    }
}
