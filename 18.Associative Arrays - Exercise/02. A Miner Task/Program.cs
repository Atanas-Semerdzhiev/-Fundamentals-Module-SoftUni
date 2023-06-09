namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> goldMap = new Dictionary<string,int>();
            string infoGoldMap;
            while ((infoGoldMap =Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if(!goldMap.ContainsKey(infoGoldMap))
                {
                    goldMap.Add(infoGoldMap, quantity);
                }
                else
                {
                    goldMap[infoGoldMap] += quantity;
                }
            }
            foreach (var item in goldMap)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
          
        }
    }
}