using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace _05._Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dragonsMembers = new Dictionary<string, Dictionary<string, List<double>>>();
            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputNumber; i++)
            {
                string[] inputInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string type = inputInfo[0];
                string name = inputInfo[1];
                double damage = 0;
                double health = 0;
                double armor = 0;
                if (inputInfo[2] != "null")
                {
                     damage = double.Parse(inputInfo[2]);
                }
                else
                {
                     damage = 45;
                }
                if (inputInfo[3] != "null")
                {
                     health = double.Parse(inputInfo[3]);
                }
                else
                {
                     health = 250;
                }
                if (inputInfo[4] != "null")
                {
                     armor = double.Parse(inputInfo[4]);
                }
                else
                {
                     armor = 10;
                }
                if(!dragonsMembers.ContainsKey(type))
                {
                    dragonsMembers.Add(type, new Dictionary<string, List<double>>());
                    dragonsMembers[type].Add(name, new List<double>());
                    dragonsMembers[type][name].Add(damage);
                    dragonsMembers[type][name].Add(health);
                    dragonsMembers[type][name].Add(armor);
                }
               
                
                    if (!dragonsMembers[type].ContainsKey(name))
                    {
                        dragonsMembers[type][name] = new List<double>();
                        dragonsMembers[type][name].Add(damage);
                        dragonsMembers[type][name].Add(health);
                        dragonsMembers[type][name].Add(armor);
                    }
                    else
                    {
                     
                        dragonsMembers[type][name][0] = damage;
                        dragonsMembers[type][name][1] = health;
                        dragonsMembers[type][name][2] = armor;
                    }
                

            }
            foreach (var type in dragonsMembers)
            {
                double avDamage =  (type.Value.Values.Select(x => x[0]).Sum()) / dragonsMembers[type.Key].Count;
                double avHealth = (type.Value.Values.Select(x => x[1]).Sum()) / dragonsMembers[type.Key].Count;
                double avArmor =  (type.Value.Values.Select(x => x[2]).Sum()) / dragonsMembers[type.Key].Count;
                Console.WriteLine($"{type.Key}::({avDamage:F2}/{avHealth:F2}/{avArmor:F2})");
                foreach (var dragon in type.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}