using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputLater = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < inputLater.Length; i++)
            {
                int currChar = inputLater[i];
                currChar += 3;
                output.Append((char)currChar);

            }
            Console.WriteLine(output.ToString());
        }
    }
}