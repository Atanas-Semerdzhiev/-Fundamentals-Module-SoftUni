namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double,int> numbersMembers = new SortedDictionary<double,int>();
            double[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray(); //8 2 2 8 2
            foreach (double number in inputNumbers)
            {
                if (!numbersMembers.ContainsKey(number))
                {
                    numbersMembers.Add(number,0);
                }
                numbersMembers[number] += 1;
            }
            foreach (var item in numbersMembers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}