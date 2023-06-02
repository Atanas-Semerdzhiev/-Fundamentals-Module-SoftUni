namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingMembers = new Dictionary<string, string>();
            int nubersCustomers = int.Parse(Console.ReadLine());
            for (int i = 0; i < nubersCustomers; i++)
            {
                string[] customersInfo = Console.ReadLine().Split();
                string command = customersInfo[0];
              
                if (command == "register")
                {
                    string name = customersInfo[1];
                    string carInfo = customersInfo[2];
                    if (!parkingMembers.ContainsKey(name))
                    {
                        parkingMembers.Add(name, carInfo);
                        Console.WriteLine($"{name} registered {carInfo} successfully");
                    }
                    else if(parkingMembers.ContainsKey(name))
                    {
                        string registeredPlateNumber = parkingMembers[name];
                        Console.WriteLine($"ERROR: already registered with plate number {carInfo}");
                    }
                }
                else if (command == "unregister")
                {
                    string name = customersInfo[1];
                   // string carInfo = customersInfo[2];
                    if (!parkingMembers.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else if (parkingMembers.ContainsKey(name))
                    {
                      
                        Console.WriteLine($"{name} unregistered successfully");
                        parkingMembers.Remove(name);
                    }
                }
            }
            foreach (var item in parkingMembers)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
            
           
        }
    }
}