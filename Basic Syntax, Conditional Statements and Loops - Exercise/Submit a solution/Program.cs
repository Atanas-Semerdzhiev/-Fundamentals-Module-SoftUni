using System;

namespace Submit_a_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int agePeople = int.Parse(Console.ReadLine());
            string condition = string.Empty;
            if (agePeople >= 0 && agePeople <= 2)
            {
                condition = "baby";
            }
            else if (agePeople >= 3 && agePeople <= 13)
            {
                condition = "child";
            }
            else if (agePeople >= 14 && agePeople <= 19)
            {
                condition = "teenager";
            }
            else if (agePeople >= 20 && agePeople <= 65)
            {
                condition = "adult";
            }
            else if (agePeople > 65)
            {
                condition = "elder";
            }

            Console.WriteLine(condition);
        }
    }
}
