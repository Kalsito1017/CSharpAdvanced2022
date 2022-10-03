using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Drawing;

namespace Basketball
{
    public class Team
    {
        public List<Player> players { get; set; }
        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }
        public Team(string name, int openPositions, char group)
        {
            players = new List<Player>();
            Name = name;
            OpenPositions = openPositions;
            Group = group;
        }
        public int Count => players.Count;
        public string AddPlayer(Player player)
        {
            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return $"Invalid player's information.";
            }
            else if (this.OpenPositions == 0)
            {
                return "There are no more open positions.";
            }
            else if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }
            else
            {
                this.players.Add(player);
                this.OpenPositions--;
                return $"Successfully added {player.Name} to the team. Remaining open positions: {this.OpenPositions}.";
            }
        }
        public bool RemovePlayer(string name)
        {
            var player = this.players.FirstOrDefault(x => x.Name == name);
            if (player == null)
            {
                return false;
            }
            this.OpenPositions++;
            this.players.Remove(player);
            return true;
        }
        public int RemovePlayerByPosition(string position)
        {
            int countRemovedPlayers = 0;
            while (this.players.FirstOrDefault(x => x.Position == position) != null)
            {
                var targetPlayer = this.players.FirstOrDefault(x => x.Position == position);
                this.OpenPositions++;
                this.players.Remove(targetPlayer);
                countRemovedPlayers++;
            }
            return countRemovedPlayers;
        }
        public Player RetirePlayer(string name)
        {

            var targetPlayer = this.players.FirstOrDefault(x => x.Name == name);
            if (targetPlayer == null)
            {
                return null;
            }
            targetPlayer.Retired = true;
            return targetPlayer;
        }
        public List<Player> AwardPlayers (int games)
        {
            List<Player> list = new List<Player>();
            foreach (var player in players.Where(s => s.Games == games))
            {
                list.Add(player);
            }
            return list;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Active players competing for Team {this.Name} from Group {this.Group}:");
            foreach (var player in this.players.Where(s => s.Retired != true))
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
