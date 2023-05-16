using System;

namespace _02._Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double averageGrade = double.Parse(Console.ReadLine());
            if (averageGrade >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
