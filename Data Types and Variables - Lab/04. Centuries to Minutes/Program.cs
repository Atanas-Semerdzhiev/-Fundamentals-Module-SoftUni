using System;

namespace _04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberLine = int.Parse(Console.ReadLine());
            int centuries = numberLine;
            int years = numberLine * 100;
            int months = years * 12;
            double days = Math.Floor(years * 365.2422);

            double hours = days * 24;
            double minutes = hours * 60;
            double seconds = minutes * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {(days)} days = {hours} hours = {minutes} minutes");
        }
    }
}
