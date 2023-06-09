using System.Diagnostics.CodeAnalysis;
using System.Security;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
           
            InitilalizesTeams(teams);
            JoinTeam(teams);
          
          
             List<Team> teamWihtMembers = teams.Where(t => t.Members.Count > 0)
                .OrderByDescending(t=>t.Members.Count)
                .ThenBy(t=>t.Name)
                .ToList();
            foreach (Team team in teamWihtMembers)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach(string member in team.Members.OrderBy(m=>m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            List<Team> teamToDisband = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.Name).ToList();
            foreach(Team team in teamToDisband)
            {
                Console.WriteLine(team.Name);
            }
       

        }
        static void JoinTeam(List<Team> teams)
        {
            string joinPlayr;
            while ((joinPlayr = Console.ReadLine()) != "end of assignment")
            {
                string[] playrsInfo = joinPlayr.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string user = playrsInfo[0];
                string teamName = playrsInfo[1];
                if (!TeanAlreadyExsest(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (AlreadyAMemberOfATeam(teams, user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team teamtoJoin = teams.First(t => t.Name == teamName);
                    teamtoJoin.AddMembers(user);
                }

            }
        }
        static void InitilalizesTeams(List<Team> teams)
        {
            int numberOfClubs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfClubs; i++)
            {
                string[] teamInfo = Console.ReadLine().Split("-").ToArray();
                string creator = teamInfo[0];
                string teamName = teamInfo[1];


                if (TeanAlreadyExsest(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (AlreadyCreatedAteam(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team newTeam = new Team(teamName, creator);
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }

            }
        }
        static bool AlreadyAMemberOfATeam(List<Team> teams,string user)
        {
            return teams.Any(t=>t.Members.Contains(user))
                || teams.Any(t => t.Creator == user);
        }
        static bool TeanAlreadyExsest(List<Team>teams, string teamName)
        {
            return teams.Any(t=>t.Name == teamName);
        }
        static bool AlreadyCreatedAteam(List<Team> teams, string creator)
        {
            return teams.Any(c =>c.Creator == creator);
        }
    }
    public class Team
    {
        private readonly List<string> members;
        public Team (string name, string Creator)
        {
            this.Name = name;
            this.Creator = Creator;
            this.members = new List<string>();
        }
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members 
            =>this.members;
        public void AddMembers( string memberName)
        {
            this.members.Add(memberName);
        }
    }
}