namespace _1._Binary_Digits_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            while (inputNumber != 0)
            {
                int currNumber = inputNumber % 2;
                if (currNumber == n)
                {
                    counter++;
                }
                inputNumber = inputNumber / 2;
              //  Console.WriteLine(currNumber);
            }
            Console.WriteLine(counter);
        }
    }
}