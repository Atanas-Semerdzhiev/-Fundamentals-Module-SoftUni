using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                 .Split(' ')
                 .ToArray();
            for (int i = 0; i < strings.Length / 2; i++)
            {
                string furstPosition = strings[i];
                string lastPosition = strings[strings.Length - 1 - i];
                strings[i] = lastPosition;
                strings[strings.Length - 1 - i] = furstPosition;
            }
            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
