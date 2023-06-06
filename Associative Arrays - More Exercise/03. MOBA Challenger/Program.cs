namespace _03._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string,int>> playerConditions = new Dictionary<string,Dictionary<string,int>>();
            Dictionary<string,int> playersPoints = new Dictionary<string,int>();
            string input;
            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains(" -> "))
                {
                    string[] playerInfo = input.Split(" -> ",StringSplitOptions.RemoveEmptyEntries); 
                    string playerName = playerInfo[0];
                    string playerPosition = playerInfo[1];
                    int playerSkill = int.Parse(playerInfo[2]);
                    if (!playerConditions.ContainsKey(playerName))
                    {
                        playerConditions[playerName]= new Dictionary<string,int>();
                        playerConditions[playerName].Add(playerPosition, playerSkill);
                        playersPoints[playerName] = playerSkill;
                    }
                    else
                    {
                        if (!playerConditions[playerName].ContainsKey(playerPosition))
                        {
                            playerConditions[playerName].Add(playerPosition, (int)playerSkill);
                            playersPoints[playerName] += playerSkill;
                        }
                        else if (playerConditions[playerName].ContainsKey(playerPosition))
                        {
                            int oldSkill = playerConditions[playerName][playerPosition];
                            if(oldSkill < playerSkill)
                            {
                                playerConditions[playerName][playerPosition] = playerSkill;
                                int diff = playerSkill - oldSkill;
                                playersPoints[playerPosition] += diff;
                            }
                        }
                    }
                }
                else if(input.Contains(" vs "))
                {
                    string[] playerInfo = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string player1 = playerInfo[0];
                    string player2 = playerInfo[1];
                    if (playerConditions.ContainsKey(player1) && playerConditions.ContainsKey(player2))
                    {
                        string playerToRemove = "";
                        foreach (var role in playerConditions[player1]) // better skillPlayer1
                        {
                            foreach (var pos in playerConditions[player2]) // better skillPlayer2
                            {
                                if (role.Key == pos.Key)
                                {
                                    if (playerConditions[player1].Values.Sum() > playerConditions[player2].Values.Sum())
                                    {
                                        playerToRemove = player2;
                                    }
                                    else if (playerConditions[player1].Values.Sum() <
                                             playerConditions[player2].Values.Sum())
                                    {
                                        playerToRemove = player1;
                                    }
                                }
                                playerConditions.Remove(playerToRemove);
                                playersPoints.Remove(playerToRemove);
                            }

                        }
                    }  
                }
            
            }
            foreach (var player in playersPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string name = player.Key;
                int totalSkills = player.Value;
                Console.WriteLine($"{name}: {totalSkills} skill");
                foreach (var roleSkill in playerConditions[name].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    string role = roleSkill.Key;
                    int skill = roleSkill.Value;
                    Console.WriteLine($"- {role} <::> {skill}");
                }
            }
        }
    }
}
        
    
