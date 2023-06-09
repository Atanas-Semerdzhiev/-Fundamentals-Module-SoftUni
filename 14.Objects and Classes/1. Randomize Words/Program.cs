using System;

namespace _1._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < input.Length; i++)
            {
                Random random = new Random();
                int index = random.Next(0, input.Length);
                string word = input[i];
                string nextWord = input[index];
                input[i] = word;
                input[index] = nextWord;
            }
            Console.WriteLine(String.Join(Environment.NewLine,input));
        }

    }
}




