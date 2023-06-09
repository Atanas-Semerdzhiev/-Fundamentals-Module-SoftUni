using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToArray();
            string comand;
            int[] curentInts = new int[input.Length];

            while ((comand = Console.ReadLine()) != "end")
            {
                string[] comandArg = comand.Split(" ");
                string typeComand = comandArg[0];
                if (typeComand == "exchange")
                {
                    int index = int.Parse(comandArg[1]);
                    if (index < 0 || index >= input.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {
                        input = RemoveElements(input, index);
                    }
                }
                else if (typeComand == "max" || typeComand == "min")
                {
                    string evenOrOddArg = comandArg[1];
                    int indexOfElement;
                    if (typeComand == "max")
                    {
                        indexOfElement = IndexOfMaxEvenOrMaxOdd(input, evenOrOddArg);
                    }
                    else
                    {
                        indexOfElement = IndexOfMinEvenOrMinOdd(input, evenOrOddArg);
                    }
                    if (indexOfElement == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(indexOfElement);
                }
                else if (typeComand == "first" || typeComand == "last")
                {
                    int count = int.Parse(comandArg[1]);
                    string evenOrOddArg = comandArg[2];
                    if (count > input.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    int[] elements;

                    if (typeComand == "first")
                    {
                        elements = FurstEvenOrOddElement(input, count, evenOrOddArg);
                    }
                    else
                    {
                        elements = LastEvenOrOddElement(input, count, evenOrOddArg);
                    }
                    PrintArray(elements);

                }


            }
            PrintArray(input);
        }

        private static int[] RemoveElements(int[] originalInput, int index)
        {
            int[] copyInput = new int[originalInput.Length];
            int modifadIndexInput = 0;
            for (int i = index + 1; i < originalInput.Length; i++)
            {
                copyInput[modifadIndexInput++] = originalInput[i];
            }
            for (int i = 0; i <= index; i++)
            {
                copyInput[modifadIndexInput++] = originalInput[i];
            }
            return copyInput;
        }
        static int IndexOfMaxEvenOrMaxOdd(int[] originalInput, string evenOrOddArg)
        {
            int maxIndex = -1;
            int curMax = int.MinValue;
            for (int i = 0; i < originalInput.Length; i++)
            {
                int curentNumber = originalInput[i];
                if (evenOrOddArg == "even" && curentNumber % 2 == 0)
                {
                    if (curentNumber >= curMax)
                    {
                        curMax = curentNumber;
                        maxIndex = i;
                    }
                }
                else if (evenOrOddArg == "odd" && curentNumber % 2 != 0)
                {
                    if (curentNumber >= curMax)
                    {
                        curMax = curentNumber;
                        maxIndex = i;
                    }
                }

            }
            return maxIndex;
        }
        static int IndexOfMinEvenOrMinOdd(int[] originalInput, string evenOrOddArg)
        {
            int minIndex = -1;
            int curMin = int.MaxValue;
            for (int i = 0; i < originalInput.Length; i++)
            {
                int curentNumber = originalInput[i];
                if (evenOrOddArg == "even" && curentNumber % 2 == 0)
                {
                    if (curentNumber <= curMin)
                    {
                        curMin = curentNumber;
                        minIndex = i;
                    }
                }
                else if (evenOrOddArg == "odd" && curentNumber % 2 != 0)
                {
                    if (curentNumber <= curMin)
                    {
                        curMin = curentNumber;
                        minIndex = i;
                    }
                }

            }
            return minIndex;
        }
        static int[] FurstEvenOrOddElement(int[] originalInput, int count, string evenOrOddArg)
        {
            int[] furstElement = new int[count];
            int indexOffurstElement = 0;
            for (int i = 0; i < originalInput.Length; i++)
            {
                int curentNum = originalInput[i];
                if (evenOrOddArg == "even" && curentNum % 2 == 0)
                {
                    if (indexOffurstElement >= count)
                    {
                        break;
                    }
                    furstElement[indexOffurstElement++] = curentNum;
                }
                if (evenOrOddArg == "odd" && curentNum % 2 != 0)
                {
                    if (indexOffurstElement >= count)
                    {
                        break;
                    }
                    furstElement[indexOffurstElement++] = curentNum;
                }

            }
            furstElement = ResyzeArray(furstElement, indexOffurstElement);
            return furstElement;
        }
        static int[] LastEvenOrOddElement(int[] originalInput, int count, string evenOrOddArg)
        {
            int[] lastElement = new int[count];
            int indexOfLastElement = 0;
            for (int i = originalInput.Length - 1; i >= 0; i--)
            {
                int curentNum = originalInput[i];
                if (evenOrOddArg == "even" && curentNum % 2 == 0)
                {
                    if (indexOfLastElement >= count)
                    {
                        break;
                    }
                    lastElement[indexOfLastElement++] = curentNum;
                }
                if (evenOrOddArg == "odd" && curentNum % 2 != 0)
                {
                    if (indexOfLastElement >= count)
                    {
                        break;
                    }
                    lastElement[indexOfLastElement++] = curentNum;
                }

            }
            lastElement = ResyzeArray(lastElement, indexOfLastElement);
            lastElement = ReversArray(lastElement);
            return lastElement;
        }
        static int[] ReversArray(int[] originalArr)
        {
            int[] reversed = new int[originalArr.Length];
            for (int i = originalArr.Length - 1; i >= 0; i--)
            {
                reversed[reversed.Length - 1 - i] = originalArr[i];
            }
            return reversed;
        }
        static int[] ResyzeArray(int[] originalInput, int count)
        {
            int[] modifidArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                modifidArray[i] = originalInput[i];
            }
            return modifidArray;
        }
        static void PrintArray(int[] arr)
        {
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }
    }
}
