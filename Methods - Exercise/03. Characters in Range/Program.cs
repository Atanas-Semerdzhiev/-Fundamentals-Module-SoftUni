using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            CharCounter(start, end);


        }

        private static void CharCounter(char start, char end)
        {
            int finish = end - start;
            if (finish > 0)
            {


                for (int i = 1; i < Math.Abs(end - start); i++)
                {
                    char curenChar = (char)(start + i);
                    Console.Write($"{curenChar} ");
                }
                return;
            }
            else if (finish < 0)
            {
                int finaly = Math.Abs(finish);
                for (int i = 1; i < finaly; i++)
                {
                    char curenChar = (char)(end + i);
                    Console.Write($"{curenChar} ");
                }
                return;
            }
        }
    }
}
