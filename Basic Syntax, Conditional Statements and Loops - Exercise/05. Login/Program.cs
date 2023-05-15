using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameToPerson = Console.ReadLine();
            string password = string.Empty;
            bool corectPassword = false;
            int counter = 0;
            for (int i = 0; i < nameToPerson.Length; i++)
            {
                password += nameToPerson[nameToPerson.Length - 1 - i];
            }
            while (corectPassword == false)
            {
                string inputPasswrd = Console.ReadLine();
                counter++;
                for (int j = 0; j < inputPasswrd.Length; j++)
                {
                    if (inputPasswrd[j] != password[j])
                    {
                        corectPassword = false;
                        break;
                    }
                    else if (inputPasswrd[j] == password[j])
                    {
                        corectPassword = true;
                    }
                }

                if (corectPassword)
                {
                    corectPassword = true;
                    break;
                }
                if (counter > 3)
                {
                    Console.WriteLine($"User {nameToPerson} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");



            }
            if (corectPassword)
            {
                Console.WriteLine($"User {nameToPerson} logged in.");
            }
        }
    }
}
