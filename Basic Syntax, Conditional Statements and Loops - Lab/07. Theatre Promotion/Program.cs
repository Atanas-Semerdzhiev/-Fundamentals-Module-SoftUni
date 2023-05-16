using System;

namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int agePerson = int.Parse(Console.ReadLine());
            int price = 0;
            if (dayOfWeek == "Weekday")
            {
                if (agePerson >= 0 && agePerson <= 18)
                {
                    price = 12;
                }
                else if (agePerson > 18 && agePerson <= 64)
                {
                    price = 18;
                }
                else if (agePerson > 64 && agePerson <= 122)
                {
                    price = 12;
                }
            }
            else if (dayOfWeek == "Weekend")
            {
                if (agePerson >= 0 && agePerson <= 18)
                {
                    price = 15;
                }
                else if (agePerson > 18 && agePerson <= 64)
                {
                    price = 20;
                }
                else if (agePerson > 64 && agePerson <= 122)
                {
                    price = 15;
                }
            }
            else if (dayOfWeek == "Holiday")
            {
                if (agePerson >= 0 && agePerson <= 18)
                {
                    price = 5;
                }
                else if (agePerson > 18 && agePerson <= 64)
                {
                    price = 12;
                }
                else if (agePerson > 64 && agePerson <= 122)
                {
                    price = 10;
                }
            }
            if (agePerson < 0 || agePerson > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{price}$");
            }
        }
    }
}
