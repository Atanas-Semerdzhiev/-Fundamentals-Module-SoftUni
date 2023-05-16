using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int maxSequence = 0;
            int curentSequence = 0;
            int integer = 0;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {


                while (inputArray[i] == inputArray[i + 1])
                {
                    curentSequence++;
                    if (curentSequence > maxSequence)
                    {
                        integer = inputArray[i];
                        maxSequence = curentSequence;
                    }
                    i++;
                    if (i == inputArray.Length - 1)
                    {
                        break;
                    }

                }
                curentSequence = 0;

            }          
                              
            for (int i = 0;i <= maxSequence;i++)
            {
                Console.Write(integer+" ");
            }
              
        }
    }
}
