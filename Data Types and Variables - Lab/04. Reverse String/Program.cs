using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string revarsString = "";
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                revarsString += inputString[i];
            }
            Console.WriteLine(revarsString);
        }
    }
}
