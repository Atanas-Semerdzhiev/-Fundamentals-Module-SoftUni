namespace _3._P_th_Bit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] result = new int[16];
            int counter = 0;
            while (inputNumber > 0)
            {

                int currNumber = inputNumber % 2;
                inputNumber = inputNumber / 2;
                result[result.Length - 1 - counter] = currNumber;
                counter++;
            }

            ConvertIntiger(inputNumber);
            Console.WriteLine($"{String.Join("", result)} -> {result[result.Length -1 - n]}");
        }

        private static int[] ConvertIntiger(int inputNumber)
        {
            throw new NotImplementedException();
        }
    }
}