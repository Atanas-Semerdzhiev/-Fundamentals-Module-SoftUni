using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = 0; i < peopleNumber; i++)
            {
                char input = char.Parse(Console.ReadLine());
                result += input;
            }
            Console.WriteLine($"The sum equals: {result}");
        }
    }
}
