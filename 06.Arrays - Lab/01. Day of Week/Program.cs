using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int courentDay = int.Parse(Console.ReadLine());
            int counters = 0;
            if (courentDay <= 7 && courentDay >= 1)
            {
                for (int i = 0; i < courentDay; i++)
                {
                    counters++;
                }
                counters--;
                Console.WriteLine(dayOfWeek[counters]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
