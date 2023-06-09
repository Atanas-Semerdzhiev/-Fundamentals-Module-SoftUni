namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonymos = new Dictionary<string, List<string>>();
            int nuberWord = int.Parse(Console.ReadLine());
            for (int i = 0; i < nuberWord; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!synonymos.ContainsKey(word))
                {
                    synonymos.Add(word, new List<string>());
                }
                synonymos[word].Add(synonym);
            }
            foreach ( var item in synonymos)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}