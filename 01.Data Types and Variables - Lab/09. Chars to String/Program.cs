using System;

namespace _09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string newOutput = "";
            for (int i = 0; i < 3; i++)
            {
                char furst = char.Parse(Console.ReadLine());
                newOutput += furst;
            }
            Console.WriteLine(newOutput);
        }
    }
}
