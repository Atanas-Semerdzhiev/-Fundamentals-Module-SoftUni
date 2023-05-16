using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = GetVowelsCount(input);
            Console.WriteLine(result);


        }
        static int GetVowelsCount(string input)
        {
            int vowelsCount = 0;
            char[] chars = new char[] { 'a', 'o', 'e', 'u', 'i', 'y' };
            foreach (char leter in input.ToLower())
            {
                if (chars.Contains(leter))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
