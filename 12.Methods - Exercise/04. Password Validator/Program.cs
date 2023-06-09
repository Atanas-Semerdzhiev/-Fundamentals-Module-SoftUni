using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool CharactersCounter1 = CharactersCounter(password);
            bool IsPasswordAlphaNumeric1 = IsPasswordAlphaNumeric(password);
            bool IsPasswordContainsTowDigit1 = IsPasswordContainsTowDigit(password);
            if (CharactersCounter1 != true)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!IsPasswordAlphaNumeric1)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }


            if (IsPasswordContainsTowDigit1 != true)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }


            if (IsPasswordAlphaNumeric1 == true && IsPasswordContainsTowDigit1 == true && CharactersCounter1 == true)
            {
                Console.WriteLine("Password is valid");
            }



        }
        static bool CharactersCounter(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                counter++;
            }
            if (counter >= 6 && counter <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool IsPasswordAlphaNumeric(string password)
        {
            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsPasswordContainsTowDigit(string password)
        {
            int digiteCounter = 0;
            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digiteCounter++;
                }
            }
            if (digiteCounter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
