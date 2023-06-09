using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            int multiplayer = int.Parse(Console.ReadLine());
            StringBuilder result =new StringBuilder();
            int reminder = 0;
            if (firstNumber == "0" || multiplayer == 0)
            {
                return;
            }
            for (int i = firstNumber.Length-1; i >= 0; i--)
            {
                int currNumber = int.Parse(firstNumber[i].ToString());
                int product = currNumber * multiplayer + reminder;
                int currResult = product % 10;
                reminder = product / 10;
                result.Insert(0, currResult);
            }

            if (reminder > 0)
            {
                result.Insert(0, reminder);
            }
            Console.WriteLine(result.ToString());
        }
    }
}