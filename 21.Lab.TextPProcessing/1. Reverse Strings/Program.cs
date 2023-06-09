namespace _1._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = String.Empty;
            while ((words = Console.ReadLine()) != "end")
            {
                string newString = String.Empty;
                for (int i = 0; i < words.Length; i++)
                {
                    newString += words[(words.Length - 1) -i];
                }
                Console.WriteLine($"{words} = {newString}");
            }
        }
    }
}