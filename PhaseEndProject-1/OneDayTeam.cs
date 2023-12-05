using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEndProject_1
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public int teamCapacity;

        public OneDayTeam()
        {
            teamCapacity = 11;
        }

        public void Add(Player player)
        {
            if (oneDayTeam.Count() < teamCapacity)
            {
                oneDayTeam.Add(player);
                Console.WriteLine("Player added successfully.");
            }
            else Console.WriteLine("Player count reached 11. Max limit of team reached.");
        }

        public void Remove(int playerId) 
        {
            foreach (Player item in oneDayTeam)
            {
                if(item.PlayerId == playerId)
                {
                    oneDayTeam.Remove(item);
                    break;
                }
            }
            Console.WriteLine("Player removed successfully.");
        }

        public Player GetPlayerById(int playerId)
        {
            
            Player player = new Player();
            foreach (Player item in oneDayTeam)
            {
                if (item.PlayerId == playerId)
                {
                    player = item;
                }
            }
            return player;
        }

        public Player GetPlayerByName(string playerName)
        {
            Player player = new Player();
            foreach (Player item in oneDayTeam)
            {
                if (item.PlayerName.ToLower() == playerName)
                {
                    player = item;
                }
            }
            return player;
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }

    }
}
