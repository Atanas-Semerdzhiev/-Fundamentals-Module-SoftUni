using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNomber = int.Parse(Console.ReadLine());
            int[] furstSum = new int[inputNomber];
            int[] secondSum = new int[inputNomber];
            for (int i = 0; i < inputNomber; i++)
            {
                int[] newInput = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 != 0)
                {

                    furstSum[i] = newInput[0];
                    secondSum[i] = newInput[newInput.Length - 1];
                }
                else
                {
                    furstSum[i] = newInput[newInput.Length - 1];
                    secondSum[i] = newInput[0];
                }



            }


            for (int i = 0; i < secondSum.Length; i++)
            {
                Console.Write($"{secondSum[0 + i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < furstSum.Length; i++)
            {
                Console.Write($"{furstSum[0 + i]} ");
            }
        }
    }
}
