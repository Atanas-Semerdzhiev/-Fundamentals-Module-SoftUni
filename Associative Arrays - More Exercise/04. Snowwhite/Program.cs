using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace _04._Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Dictionary<string,Dictionary<string,int>> dwarfMembers = new Dictionary<string, Dictionary<string, int>>();
            
              string input= String.Empty;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] inputInfo = input.Split(" <:> ");
                string dwarfName = inputInfo[0];
                string dwarfHatColor = inputInfo[1];
                int dwarfPhysics = int.Parse(inputInfo[2]);
                if(!dwarfMembers.ContainsKey(dwarfHatColor) )
                {
                    dwarfMembers[dwarfHatColor] = new Dictionary<string, int>();
                    dwarfMembers[dwarfHatColor].Add(dwarfName, dwarfPhysics);
               
                }
                else if(dwarfMembers.ContainsKey((string)dwarfHatColor))
                {
                    if (!dwarfMembers[dwarfHatColor].ContainsKey(dwarfName))
                    {
                      //   dwarfMembers.Add(dwarfHatColor, new Dictionary<string, int>()) ;
                          dwarfMembers[dwarfHatColor].Add(dwarfName, dwarfPhysics);
                 
                    }
                    else if (dwarfMembers[dwarfHatColor].ContainsKey(dwarfName))
                    {
                        int oldPfysics = dwarfMembers[dwarfHatColor][dwarfName];
                        if (oldPfysics < dwarfPhysics)
                        {
                            dwarfMembers[dwarfHatColor][dwarfName] = dwarfPhysics;
                        }
                    }
                }
            }
            var sortDwarf = new Dictionary<int, Dictionary<int, Dictionary<string, string>>>();
            dwarfMembers = dwarfMembers.OrderByDescending(x => x.Value.Values.Max())
                .ThenByDescending(x => x.Value.Values.Count).ToDictionary(a => a.Key, b => b.Value);
            int dwarfNumber = 1;
            foreach (var (color, dwarfs) in dwarfMembers)
            {
                foreach (var (name, power) in dwarfs)
                {
                    sortDwarf[dwarfNumber] = new Dictionary<int, Dictionary<string, string>>();
                    sortDwarf[dwarfNumber][power] = new Dictionary<string, string>();
                    sortDwarf[dwarfNumber][power][name] = color;
                    dwarfNumber++;
                }
            }
            sortDwarf = sortDwarf
          .OrderByDescending(d => d.Value.Keys.Max())
          .ToDictionary(x => x.Key, x => x.Value);

            foreach (var (number, dwarf) in sortDwarf)
            {
                foreach (var (power, nameAndColor) in dwarf)
                {
                    foreach (var (name, color) in nameAndColor)
                    {
                        Console.WriteLine($"({color}) {name} <-> {power}");

                    }
                }
            }
        }
    }
 
}