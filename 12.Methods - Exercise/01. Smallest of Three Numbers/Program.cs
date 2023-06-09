using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int furstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());
            int result = GetMax(furstInteger, secondInteger, thirdInteger);
            Console.WriteLine(result);
        }

        private static int GetMax(int furstInteger, int secondInteger, int thirdInteger)
        {
            int result = 0;
            if (furstInteger <= secondInteger)
            {
                if (furstInteger <= thirdInteger)
                {
                    result = furstInteger;
                }
                else
                {
                    result = thirdInteger;
                }


            }
            else
            {
                if (thirdInteger <= secondInteger)
                {
                    result = thirdInteger;
                }
                else
                {
                    result = secondInteger;
                }


            }



            return result;
        }
    }
}
