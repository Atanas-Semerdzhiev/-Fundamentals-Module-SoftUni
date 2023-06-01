namespace _02._Odd_Occurrencess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split()
                .Where(x => x.Length % 2 == 0).ToArray() ;
            foreach (string word in words)
            {
                Console.WriteLine(word) ;
            }
        }
    }
}