using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstIndex = int.Parse(Console.ReadLine());
            int secondIndex = int.Parse(Console.ReadLine());

            if (secondIndex <= 10)
            {


                for (int i = secondIndex; i <= 10; i++)
                {
                    Console.WriteLine($"{firstIndex} X {i} = {firstIndex * i}");

                }
            }
            else
            {
                Console.WriteLine($"{firstIndex} X {secondIndex} = {firstIndex * secondIndex}");
            }
        }
    }
}
