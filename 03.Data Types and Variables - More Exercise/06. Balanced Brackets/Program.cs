using System;

namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lineForRead = int.Parse(Console.ReadLine());
            int leftCounter = 0;
            int rightCounter = 0;
            for (int i = 0; i < lineForRead; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    leftCounter++;
                }
                else if (input == ")")
                {
                    rightCounter++;
                    if (rightCounter > leftCounter)
                    {
                        break;
                    }
                }

            }
            if (leftCounter == rightCounter)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.Write("UNBALANCED");
            }
        }
    }
}
