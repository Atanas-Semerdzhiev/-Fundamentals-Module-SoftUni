using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] newInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            int[] inputInts = new int[newInput.Length];
            for (int i = 0; i < newInput.Length; i++)
            {
                inputInts[i] = int.Parse(newInput[i]);
            }
            int[] furstarray = new int[inputInts.Length / 2];
            for (int i = 0; i < furstarray.Length; i++)
            {
                furstarray[i] = inputInts[i];
            }
            int[] secondArray = new int[inputInts.Length / 2];
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = inputInts[i + secondArray.Length];
            }
            for (int i = (furstarray.Length) / 2; i > 0; i--)
            {
                int furstInts = furstarray[i - 1];
                int secondInts = furstarray[((furstarray.Length)) - i];
                int furstResult = furstInts + secondInts;

                Console.Write(furstResult + " ");

            }
            for (int i = 0; i < (secondArray.Length) / 2; i++)
            {
                int furstInts2 = secondArray[i];
                int secondInts2 = secondArray[(secondArray.Length - 1) - i];
                int secontresult = furstInts2 + secondInts2;
                Console.Write(secontresult + " ");
            }
        }
    }
}
