namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> keyValuePairs = new Dictionary<string,List<string>>();
            string inputInfo;
            while((inputInfo = Console.ReadLine()) != "End")
            {
                string[] companyInfo = inputInfo.Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                string companyName = companyInfo[0];
                string employeeID = companyInfo[1];
                if(!keyValuePairs.ContainsKey(companyName) )
                {
                    keyValuePairs.Add(companyName, new List<string>());
                    keyValuePairs[companyName].Add( employeeID);
                }
                if (!keyValuePairs[companyName].Contains(employeeID ))
                {
                    keyValuePairs[companyName].Add(employeeID);
                }
            }
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var employeeID in item.Value)
                {
                    Console.WriteLine($"-- {employeeID}");
                }
            }
        }
    }
}