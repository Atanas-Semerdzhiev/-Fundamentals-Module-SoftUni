using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberWagons = int.Parse(Console.ReadLine());
            int[] peopleinWagons = new int[numberWagons];
            int sumPeople = 0;
            for (int i = 0; i < numberWagons; i++)
            {
                peopleinWagons[i] = int.Parse(Console.ReadLine());
                sumPeople += peopleinWagons[i];
            }
            for (int i = 0; i < peopleinWagons.Length; i++)
            {
                int pasangers = peopleinWagons[0 + i];
                Console.Write($"{pasangers} ");
            }
            Console.WriteLine();

            Console.WriteLine(sumPeople);
        }
    }
}
