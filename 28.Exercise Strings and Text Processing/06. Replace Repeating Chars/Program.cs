namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = (Console.ReadLine());
            char previousChar = text[0];
            Console.Write(previousChar);
            for (int i = 1; i < text.Length; i++)
            {
                char curentChar = text[i];
                if ((previousChar != curentChar))
                {

                  previousChar = curentChar;
                  Console.Write(previousChar);
                }
            }
        }
    }
}