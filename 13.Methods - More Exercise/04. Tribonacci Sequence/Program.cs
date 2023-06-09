using System;

namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stop = int.Parse(Console.ReadLine());
            int[] result = new int[stop];
            result[0] = 1;
            for (int positcion = 0; positcion < stop; positcion++)
            {
                int counter = 0;
                int sum = 0;
                for (int i = positcion; i >= 0; i--)
                {
                    counter++;
                    sum += result[i];
                    if (counter > 3)
                    {
                        break;
                    }

                }
                result[positcion] = sum;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
