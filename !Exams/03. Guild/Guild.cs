using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        public List<Player> Roster { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public Guild( string name, int capacity)
        {
            Roster = new List<Player>();
            Name = name;
            Capacity = capacity;
        }
        public int Count => Roster.Count;
        public void AddPlayer(Player player)
        {
            if (Count < Capacity)
            {
                Roster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            if (Roster.Any(s => s.Name == name))
            {
                Player player = Roster.FirstOrDefault(s => s.Name == name);
               
                return Roster.Remove(player);
            }
            return false;
        }
        public void PromotePlayer(string name) => Roster.First(s => s.Name == name).Rank = "Member";
        public void DemotePlayer(string name) => Roster.First(s => s.Name == name).Rank = "Trial";
        public Player[] KickPlayersByClass(string @class)
        {
            Player[] arr = Roster.Where(s => s.Class == @class).ToArray();
            Roster.RemoveAll(p => p.Class == @class);
            return arr;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (Player item in Roster)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }
        
            
        
    }
}
