using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputSring = Console.ReadLine();

            string inTheMiddle = MiddleCharacters(inputSring);
            Console.WriteLine(inTheMiddle);


        }

        private static string MiddleCharacters(string inputSring)
        {
            if (inputSring.Length % 2 == 0)
            {
                char furstChar = ' ';
            char secondChar = ' ';
            for (int i = 0; i < inputSring.Length / 2; i++)
            {


                furstChar = inputSring[i];
                secondChar = inputSring[inputSring.Length - 1 - i];

            }
            return furstChar + secondChar.ToString();
        }
            else if(inputSring.Length % 2 != 0)
            {
                char furstChar = inputSring[inputSring.Length / 2];
        char secondChar = inputSring[inputSring.Length / 2 + 1];
                return furstChar.ToString();
            }
            return null;
        }
    }
}
