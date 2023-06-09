using System.ComponentModel.Design;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputSymbols = Console.ReadLine();
            foreach (var symbol in inputSymbols)
            {
                if (Char.IsDigit(symbol))
                {
                    Console.Write(symbol);
                }
              
            }
            Console.WriteLine();
            foreach (var symbol in inputSymbols)
            {
                if (Char.IsLetter(symbol))
                {
                    Console.Write(symbol);
                }
            }
            Console.WriteLine();
            foreach (var symbol in inputSymbols)
            {
                if (!Char.IsLetterOrDigit(symbol))
                {
                    Console.Write(symbol);
                }
            }
        }
    }
}