using System;

namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade = int.Parse(Console.ReadLine());

            PrintNumber(grade);


        }
        static void PrintNumber(int grade)
        {
            if (grade > 0)
            {
                Console.WriteLine($"The number {grade} is positiv.");
            }
            else if (grade < 0)
            {
                Console.WriteLine($"The number {grade} is negative.");
            }
            else if (grade == 0)
            {
                Console.WriteLine($"The number {grade} is zero.");
            }
        }
    }
}
