using System;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char furst = char.Parse(Console.ReadLine());
            char[] small = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] big = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            bool smallChar = false;
            bool bigChar = false;
            for (int i = 0; i < small.Length; i++)
            {
                if (small[i] == furst)
                {
                    smallChar = true;
                }
            }
            for (int i = 0; i < big.Length; i++)
            {
                if (big[i] == furst)
                {
                    bigChar = true;
                }
            }
            if (smallChar)
            {
                Console.WriteLine("lower-case");
            }
            if (bigChar)
            {
                Console.WriteLine("upper-case");
            }

        }
    }
}
