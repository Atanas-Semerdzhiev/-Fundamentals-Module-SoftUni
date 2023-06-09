using System;

namespace _07._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string furstInput = (Console.ReadLine());
            string secondInput = (Console.ReadLine());
            string thirdInput = (Console.ReadLine());

            Console.WriteLine($"{furstInput}{thirdInput}{secondInput}");
        }
    }
}
