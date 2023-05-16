using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int furstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int numberOne = 0;
            int numberTwo = 0;
            int numberThree = 0;
            if (furstNum > secondNum && furstNum > thirdNum)
            {
                numberOne = furstNum;
                if (secondNum > thirdNum)
                {
                    numberTwo = secondNum;
                    numberThree = thirdNum;
                }
                else if (thirdNum > secondNum)
                {
                    numberTwo = thirdNum;
                    numberThree = secondNum;
                }
                else
                {
                    numberTwo = secondNum;
                    numberThree = thirdNum;
                }
            }
            else if (secondNum > thirdNum && secondNum > thirdNum)
            {
                numberOne = secondNum;
                if (thirdNum > furstNum)
                {
                    numberTwo = thirdNum;
                    numberThree = furstNum;
                }
                else if (thirdNum < furstNum)
                {
                    numberTwo = furstNum;
                    numberThree = thirdNum;
                }
                else
                {
                    numberTwo = furstNum;
                    numberThree = thirdNum;
                }
            }
            else if (thirdNum > furstNum && thirdNum > secondNum)
            {
                numberOne = thirdNum;
                if (furstNum > secondNum)
                {
                    numberTwo = furstNum;
                    numberThree = secondNum;
                }
                else if (secondNum > furstNum)
                {
                    numberTwo = secondNum;
                    numberThree = furstNum;
                }
                else
                {
                    numberTwo = secondNum;
                    numberThree = furstNum;
                }
            }
            else if (furstNum == secondNum && secondNum == thirdNum)
            {
                numberOne = furstNum;
                numberTwo = secondNum;
                numberThree = thirdNum;
            }
            else if (furstNum == secondNum)
            {
                if (furstNum > thirdNum)
                {
                    numberOne = furstNum;
                    numberTwo = secondNum;
                    numberThree = thirdNum;
                }
                else if (furstNum < thirdNum)
                {
                    numberOne = thirdNum;
                    numberTwo = furstNum;
                    numberThree = secondNum;
                }
            }
            else if (furstNum == thirdNum)
            {
                if (furstNum > secondNum)
                {
                    numberOne = furstNum;
                    numberTwo = thirdNum;
                    numberThree = secondNum;
                }
                else if (furstNum < secondNum)
                {
                    numberOne = secondNum;
                    numberTwo = thirdNum;
                    numberThree = furstNum;
                }
            }
            else if (secondNum == thirdNum)
            {
                if (furstNum > secondNum)
                {
                    numberOne = furstNum;
                    numberTwo = secondNum;
                    numberThree = thirdNum;
                }
                else if (secondNum > furstNum)
                {
                    numberOne = secondNum;
                    numberTwo = furstNum;
                    numberThree = secondNum;

                }
            }


            Console.WriteLine($"{numberOne}");
            Console.WriteLine($"{numberTwo}");
            Console.WriteLine($"{numberThree}");
        }
    }
}
