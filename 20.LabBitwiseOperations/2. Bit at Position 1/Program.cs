namespace _2._Bit_at_Position_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int[] result = new int[8];
            int counter = 0;
            while (inputNumber > 0)
            {
               
                int currNumber = inputNumber % 2;
                inputNumber = inputNumber / 2;
                result[result.Length - 1 -counter] = currNumber;
                counter++;
            }

            Console.WriteLine($"{String.Join("",result)} -> {result[result.Length-2]}");
        }
    }
}