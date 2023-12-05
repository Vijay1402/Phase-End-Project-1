using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEndProject_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam odt = new OneDayTeam();
            string cont = "";
            do
            {
                Console.WriteLine("Enter 1:To Add Player 2:To Remove Player by Id 3.Get Player By Id 4.Get Player by Name 5.Get All Players:");
                int op = int.Parse(Console.ReadLine());                
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("Please enter Player ID");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter Player Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Please enter Player Age");
                            int age = int.Parse(Console.ReadLine());
                            Player player = new Player()
                            {
                                PlayerId = id,
                                PlayerName = name,
                                PlayerAge = age
                            };
                            odt.Add(player);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Please enter Player's ID to be removed");
                            int ID = int.Parse(Console.ReadLine());
                            odt.Remove(ID);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Please enter Player's ID to view");
                            int ID = int.Parse(Console.ReadLine());
                            Player player = odt.GetPlayerById(ID);
                            if (player != null)
                            {
                                Console.WriteLine("Player ID:\t" + player.PlayerId + "\nPlayer Name:\t" + player.PlayerName + "\nPlayer Age:\t" + player.PlayerAge);
                            }
                            else
                            {
                                Console.WriteLine("Player not found. Invalid ID");
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Please enter Player's Name to view");
                            string name = Console.ReadLine().ToLower();
                            Player player = odt.GetPlayerByName(name);
                            if (player != null)
                            {
                                Console.WriteLine("Player ID:\t" + player.PlayerId + "\nPlayer Name:\t" + player.PlayerName + "\nPlayer Age:\t" + player.PlayerAge);
                            }
                            else
                            {
                                Console.WriteLine("Player not found. Invalid Name");
                            }
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Here is the full list of Players");
                            List<Player> odtDisp = new List<Player>();
                            odtDisp = odt.GetAllPlayers();
                            foreach (Player player in odtDisp)
                            {
                                Console.WriteLine("Player ID:\t" + player.PlayerId + "\nPlayer Name:\t" + player.PlayerName + "\nPlayer Age:\t" + player.PlayerAge + "\n");
                            }
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid Option");
                        }
                        break;
                }
                Console.WriteLine("Please enter M to go back to main menu");
                cont = Console.ReadLine();
            } while (cont.ToLower() == "m");
        }
    }
}
               

