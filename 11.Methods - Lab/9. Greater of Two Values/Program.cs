using System;

namespace _9._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string velue1 = Console.ReadLine();
            string velue2 = Console.ReadLine();
            if (type == "string")
            {
                string result = GetMax(velue1, velue2);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char furstVelue = char.Parse(velue1);
                char secondVelue = char.Parse(velue2);
                char result = GetMax(furstVelue, secondVelue);
                Console.WriteLine(result);
            }
            else if (type == "int")
            {
                int furstVelue = int.Parse(velue1);
                int secondVelue = int.Parse(velue2);
                int result = GetMax(furstVelue, secondVelue);
                Console.WriteLine(result);
            }
        }

        private static string GetMax(string velue1, string velue2)
        {
            int result = velue1.CompareTo(velue2);
            if (result == 0)
            {
                return velue1;
            }
            return velue2;
        }
        private static int GetMax(int furstVelue, int secondVelue)
        {

            if (furstVelue > secondVelue)
            {
                return furstVelue;
            }
            return secondVelue;
        }
        private static char GetMax(char furstVelue, char secondVelue)

        {
            if (furstVelue > secondVelue)
            {
                return furstVelue;
            }
            return secondVelue;
        }
    }
}
