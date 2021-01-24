using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        private Guild()
        {
            this.roster = new List<Player>();
        }
        public Guild(string name, int capacity) : this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get; }
        public int Capacity { get; }
        public int Count => this.roster.Count();

        public void AddPlayer(Player player)
        {
            if (this.roster.Count + 1 <= Capacity)
            {
                this.roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player player = this.roster.FirstOrDefault(p => p.Name == name);

            if (player != null)
            {
                this.roster.Remove(player);
                return true;
            }

            return false;
        }

        public void PromotePlayer(string name)
        {
            Player player = this.roster.FirstOrDefault(p => p.Name == name);

            if (player.Rank != "Member")
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player player = this.roster.FirstOrDefault(p => p.Name == name);

            if (player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string @class)
        {
            Player[] arrayPlayers = this.roster.Where(p=>p.Class == @class).ToArray();

            // foreach (Player player in this.roster)
            // {
            //     if (player.Class == @class)
            //     {
            //         arrayPlayers.Add(player);
            //     }
            // }

            this.roster.RemoveAll(p => p.Class == @class);

            return arrayPlayers;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (Player player in this.roster)
            {
                sb.AppendLine($"{player}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
