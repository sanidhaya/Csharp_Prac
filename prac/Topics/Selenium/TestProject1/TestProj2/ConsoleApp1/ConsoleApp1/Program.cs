using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number of players \n");
                var Players = Console.ReadLine();
                var PlayerNum = int.Parse(Players);
                Console.WriteLine("Enter the maximum length of game: \n");
                var MaxLen = Console.ReadLine();
                var MaxLength = int.Parse(MaxLen);
                Game game = new Game(PlayerNum, MaxLength);
                game.StartGame();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number for the number of players.");
            }
            Console.ReadLine();
        }
    }
}
