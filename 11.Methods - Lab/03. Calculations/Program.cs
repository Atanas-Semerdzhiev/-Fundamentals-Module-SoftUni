using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int furstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            if (comand == "add")
            {
                DoAdd(furstInteger, secondInteger);
            }
            else if (comand == "multiply")
            {
                DoMultiply(furstInteger, secondInteger);
            }
            else if (comand == "subtract")
            {
                DoSubtract(furstInteger, secondInteger);
            }
            else if (comand == "divide")
            {
                DoDivide(furstInteger, secondInteger);
            }

        }

        private static void DoDivide(int furstInteger, int secondInteger)
        {
            int result = furstInteger / secondInteger;
            Console.WriteLine(result);
        }

        private static void DoSubtract(int furstInteger, int secondInteger)
        {
            int result = furstInteger - secondInteger;
            Console.WriteLine(result);
        }

        private static void DoMultiply(int furstInteger, int secondInteger)
        {
            int result = furstInteger * secondInteger;
            Console.WriteLine(result);
        }

        private static void DoAdd(int furstInteger, int secondInteger)
        {
            int result = furstInteger + secondInteger;
            Console.WriteLine(result);
        }
    }
}
