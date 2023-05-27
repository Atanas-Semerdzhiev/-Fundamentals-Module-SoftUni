namespace _02._Articless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputText = Console.ReadLine().Split(",").ToList();

            int inputNumber = int.Parse(Console.ReadLine());

            var article = new Articles
            {
                Title = inputText[0],
                Content = inputText[1],
                Author = inputText[2]

            };
            for (int i = 0; i < inputNumber; i++)
            {
                List<string> newText = Console.ReadLine().Split(":",StringSplitOptions.RemoveEmptyEntries).ToList();
                if (newText[0] == "Edit")
                {
                    article.Content = newText[1];
                }
                else if (newText[0] == "ChangeAuthor")
                {
                    article.Author = newText[1];
                }
                else if (newText[0] == "Rename")
                {
                    article.Title = newText[1];
                }
            }
            Console.WriteLine($"{article.Title} -{article.Content}:{article.Author}");

        }
    }
    public class Articles
    {
      

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}