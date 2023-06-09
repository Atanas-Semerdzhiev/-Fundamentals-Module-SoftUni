using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string furstInteger = (Console.ReadLine());
            int newInteger = 0;
            for (int i = 0; i < furstInteger.Length; i++)
            {
                newInteger += furstInteger[i] - 48;
            }
            Console.WriteLine(newInteger);
        }
    }
}
