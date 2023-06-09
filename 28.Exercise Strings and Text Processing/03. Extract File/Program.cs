namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputInfo = Console.ReadLine().Split("\\");
            string file = inputInfo[inputInfo.Length - 1];
            string[] splitLastWord = file.Split('.');
            Console.WriteLine($"File name: {splitLastWord[0]}");
            Console.WriteLine($"File extension: {splitLastWord[1]}");
        }
    }
}