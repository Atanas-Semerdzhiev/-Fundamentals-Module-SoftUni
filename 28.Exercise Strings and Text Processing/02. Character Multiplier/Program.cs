namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().Split();
            GetStringSum(inputString[0], inputString[1]);
        }

        private static void GetStringSum(string stringOne, string stringTwo)
        {

            int sum = 0;
            int minLength = Math.Min(stringOne.Length, stringTwo.Length);
            for (int i = 0; i < minLength; i++)
            {
                sum += stringOne[i] * stringTwo[i];
            }
            string longesString = stringOne;
            if (stringTwo.Length > longesString.Length)
            {
                longesString = stringTwo;
            }
            for (int i = minLength; i < longesString.Length; i++)
            {
                sum += longesString[i];

            }
            Console.WriteLine(sum);
        }
    }
}