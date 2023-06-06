using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> pleyarInfo = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> pleyarSkills = new Dictionary<string, int>();
            string inputInfo = String.Empty;
            while ((inputInfo = Console.ReadLine()) != "Season end")
            {
                if (inputInfo.Contains(" -> "))
                {


                    string[] pleyarPositionSkill = inputInfo.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string pleyarName = pleyarPositionSkill[0];
                    string pleyarPosition = pleyarPositionSkill[1];
                    int pleyarSkill = int.Parse(pleyarPositionSkill[2]);
                    if (!pleyarInfo.ContainsKey(pleyarName))
                    {
                        pleyarInfo[pleyarName] = new Dictionary<string, int>();
                       
                        pleyarSkills.Add(pleyarPosition, pleyarSkill);
                    }
                    if (!pleyarInfo[pleyarName].ContainsKey(pleyarPosition))
                    {
                        pleyarInfo[pleyarName][pleyarPosition] = 0;
                        pleyarSkills[pleyarPosition] += pleyarSkill;
                    }
                    pleyarInfo[pleyarName][pleyarPosition] += pleyarSkill;
                    pleyarSkills[pleyarPosition] += pleyarSkill;
                }
                else if (inputInfo.Contains(" vs "))
                {
                    string[] pleyarPositionSkill = inputInfo.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string firstPleyar = pleyarPositionSkill[0];
                    string secondPleyar = pleyarPositionSkill[1];
                    if (pleyarInfo.ContainsKey(firstPleyar) && pleyarInfo.ContainsKey(secondPleyar))
                    {
                        string playerToRemove = "";
                        foreach (var skill1 in pleyarInfo[firstPleyar])
                        {
                            foreach (var skill2 in pleyarInfo[secondPleyar])
                            {
                                if (skill1.Key == skill2.Key)
                                {
                                    if (pleyarInfo[firstPleyar].Values.Sum() > pleyarInfo[secondPleyar].Values.Sum())
                                    {
                                        playerToRemove = secondPleyar;
                                    }
                                    else if (pleyarInfo[secondPleyar].Values.Sum() > pleyarInfo[firstPleyar].Values.Sum())
                                    {
                                        playerToRemove = firstPleyar;
                                    }
                                }
                            }
                            pleyarInfo.Remove(playerToRemove);
                            pleyarSkills.Remove(playerToRemove);
                        }
                    }
                }
            }

            foreach (var player in pleyarSkills.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string name = player.Key;
                int totalSkills = player.Value;
                Console.WriteLine($"{name}: {totalSkills} skill");

               
                foreach (var roleSkill in pleyarInfo[name].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    string role = roleSkill.Key;
                    int skill = roleSkill.Value;
                    Console.WriteLine($"- {role} <::> {skill}");
                }
            }
        }      
       
    }
}