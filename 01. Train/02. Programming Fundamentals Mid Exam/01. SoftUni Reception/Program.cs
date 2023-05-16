using System;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int workEfficiency = 0;
            for (int i = 0; i < 3; i++)
            {
                workEfficiency += int.Parse(Console.ReadLine());
            }
            int numberStudent = int.Parse(Console.ReadLine());
            int neededHours = 0;
            while (numberStudent > 0)
            {
                neededHours++;

                if (neededHours % 4 == 0)
                {
                    continue;
                }

                numberStudent -= workEfficiency;
            }


            Console.WriteLine($"Time needed: {neededHours}h.");
        }
    }
}
