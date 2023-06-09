namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWord = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach (var currentBannedWord in bannedWord)
            {
                text = text.Replace(
            currentBannedWord, new string('*', currentBannedWord.Length));
            }
            Console.WriteLine(text);
        }
    }
}