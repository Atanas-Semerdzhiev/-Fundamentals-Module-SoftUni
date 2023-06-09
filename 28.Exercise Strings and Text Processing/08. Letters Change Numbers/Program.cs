namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            double sum = 0;
            foreach (string item in inputArray)
            {
                char firstLeter = item[0];
                char lastLeter = item[^1];
                string numberAsString = item[1..^1];
                double numberFromString = double.Parse(numberAsString);
                if (char.IsUpper(firstLeter))
                {
                    int positionOfTheLeter = firstLeter - 64;
                    numberFromString /= positionOfTheLeter;
                }
                else
                {
                    int positionOfTheLeter = firstLeter - 96;
                    numberFromString *= positionOfTheLeter;
                }

                if (char.IsUpper(lastLeter))
                {
                    int positionOfTheLeter = lastLeter - 64;
                    numberFromString -= positionOfTheLeter;
                }
                else
                {
                    int positionOfTheLeter = lastLeter - 96;
                    numberFromString += positionOfTheLeter;
                }
                sum += numberFromString;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}