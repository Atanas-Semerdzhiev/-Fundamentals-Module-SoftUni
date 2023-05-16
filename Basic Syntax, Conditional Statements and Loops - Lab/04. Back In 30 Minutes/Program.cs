using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int curentHours = int.Parse(Console.ReadLine());
            int curentSecond = int.Parse(Console.ReadLine());

            int culcSecond = (curentHours * 60) + (curentSecond) + 30;
            int hours = culcSecond / 60;
            double second = culcSecond % 60.0;
            if (hours == 24)
            {
                hours = 0;
            }
            if (second < 10)
            {
                Console.WriteLine($"{hours}:0{second}");
            }
            else
            {
                Console.WriteLine($"{hours}:{second}");
            }

        }
    }
}
