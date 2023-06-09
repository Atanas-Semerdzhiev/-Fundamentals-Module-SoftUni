namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string specilWord = Console.ReadLine();
            string text = Console.ReadLine();
            while (text.Contains(specilWord))
            {
                int startIndex = text.IndexOf(specilWord);
                text = text.Remove(startIndex,specilWord.Length);
            }
            Console.WriteLine(text);
        }
    }
}