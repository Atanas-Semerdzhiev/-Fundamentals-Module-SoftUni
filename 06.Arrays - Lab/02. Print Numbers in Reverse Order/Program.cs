using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int howLines = int.Parse(Console.ReadLine());
            int[] numbersArray = new int[howLines];
            for (int i = 0; i < howLines; i++)
            {
                int curentNumber = int.Parse(Console.ReadLine());
                numbersArray[i] = curentNumber;


            }
            for (int i = numbersArray.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbersArray[i]} ");
            }
        }
    }
}
