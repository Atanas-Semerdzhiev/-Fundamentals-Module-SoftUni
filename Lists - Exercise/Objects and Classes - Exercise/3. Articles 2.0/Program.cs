namespace _3._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> list = new List<Article>();
            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputNumber; i++)
            {
                List<string> inputText = Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries).ToList();
                string title = inputText[0];
                string content = inputText[1];
                string author = inputText[2];
                Article article = new Article(title, content, author);
                list.Add(article);
            }
            foreach (Article article in list)
            {
                Console.WriteLine($"{article.Title} -{article.Content}:{article.Author}");
            }
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

    }
}