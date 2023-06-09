using System;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNimbers = int.Parse(Console.ReadLine());
            while (inputNimbers % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                inputNimbers = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"The number is: {Math.Abs(inputNimbers)}");
        }
    }
}
