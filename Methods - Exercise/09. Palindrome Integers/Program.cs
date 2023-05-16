using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while ((input = Console.ReadLine()) != "END")
            {
                string outputRevers = InputRevers(input);
                bool same = ComparisonMy(input, outputRevers);
                if (same)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

        }



        private static string InputRevers(string input)
        {
            string output = " ";
            for (int i = 0; i < input.Length; i++)
            {
                output += input[input.Length - 1 - i];
            }
            return output;
        }
        private static bool ComparisonMy(string input, string outputRevers)
        {
            int furst = int.Parse(input);
            int second = int.Parse(outputRevers);
            if (furst == second)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
