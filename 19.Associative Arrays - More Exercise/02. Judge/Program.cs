namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, int>> baseDate = new Dictionary<string, SortedDictionary<string, int>>();
            string inputInfo = string.Empty;
            while ((inputInfo = Console.ReadLine()) != "no more time")
            {
                string[] studentInfo = inputInfo.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string studentName = studentInfo[0];
                string curseName = studentInfo[1];
                int points = int.Parse(studentInfo[2]);
                if (!baseDate.ContainsKey(curseName))
                {
                    baseDate[curseName] = new SortedDictionary<string, int>();
                }
                if (!baseDate[curseName].ContainsKey(studentName))
                {
                    baseDate[curseName][studentName] = 0;
                }
                if (baseDate[curseName][studentName] < points)
                {
                    baseDate[curseName][studentName] = points;
                }
            }
            //  Console.WriteLine("---------------------------------");
            foreach (var cursName in baseDate)
            {
                Console.WriteLine($"{cursName.Key}: {cursName.Value.Count} participants");
                int counter = 0;
                foreach (var studName in cursName.Value.OrderByDescending(x => x.Value))
                {
                    counter++;
                    Console.WriteLine($"{counter}. {studName.Key} <::> {studName.Value}");
                }
            }
            Console.WriteLine("Individual standings:");
            Dictionary<string, int> individualStatistics = new Dictionary<string, int>();
            foreach (var item in baseDate)
            {
                // Console.WriteLine($"{item.Key}: {item.Value.Count} participants");
                int sum = 0;
                string name = String.Empty;
                foreach (var curse in item.Value.OrderByDescending(x => x.Value))
                {
                    name = curse.Key;
                    sum = curse.Value;

                    if (!individualStatistics.ContainsKey(name))
                    {
                        individualStatistics[name] = 0;
                    }
                    if (individualStatistics.ContainsKey(name))
                    {
                        individualStatistics[name] += sum;
                    }


                }


            }
            individualStatistics = individualStatistics.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            int counter1 = 1;
            foreach (var item in individualStatistics)
            {
                Console.WriteLine($"{counter1++}. {item.Key} -> {item.Value}");
            }
        }
    }
}