using System;

namespace _05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lineForRead = int.Parse(Console.ReadLine());
            string newString = "";
            for (int i = 0; i < lineForRead; i++)
            {
                char input = char.Parse(Console.ReadLine());
                char newChar = (char)(input + key);
                newString += newChar;

            }
            Console.WriteLine(newString);
        }
    }
}
