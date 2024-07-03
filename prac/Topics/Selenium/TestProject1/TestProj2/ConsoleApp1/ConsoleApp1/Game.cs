using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        public struct ToCut
        {
            public bool Cut;
            public List<Player> multiplePlayers;
        }

        private int Players { get; set; }
        private static int MaxLength { get; set; }
        private Queue<Player> playerQueue;

        public Game(int players, int maxLength)
        {
            Players = players;
            MaxLength = maxLength;
            playerQueue = new Queue<Player>(CreatePlayers(players)); 
        }

        private List<Player> CreatePlayers(int players)
        {
            var playersList = new List<Player>();
            for (int i = 1; i <= players; i++)
            {
                playersList.Add(new Player($"Player{i}", 0, MaxLength));
            }
            return playersList;
        }


        private void GamePlay(Player player)
        {
            Console.WriteLine($"Welcome to the gamne");
            player.DisplayPlayerName();

        }
        private ToCut CheckToCut(Player currentPlayer)
        {
            var cutPlayers = new List<Player>();
            foreach (var player in playerQueue)
            {
                if (player != currentPlayer && player.position == currentPlayer.position)
                {
                    player.ResetPosition();
                    cutPlayers.Add(player);
                }
            }
            return new ToCut { Cut = cutPlayers.Any(), multiplePlayers = cutPlayers };
        }


        private void StartGame_()
        {
            bool gameEnded = false;
            playerQueue = new Queue<Player>(CreatePlayers(Players)); // Initialize the playerQueue

            while (!gameEnded && playerQueue.Count > 0)
            {
                var currentPlayer = playerQueue.Dequeue();
                Console.WriteLine($"Current Position: {currentPlayer.position} \n Try Rolling dice by pressing enter");
                Console.ReadLine();
                int diceRoll = currentPlayer.RollDice();
                Console.WriteLine($"Rolled to num {diceRoll}");

                try
                {
                    currentPlayer.MovePositions(diceRoll); // Update this method to not throw exceptions
                    GamePlay(currentPlayer);
                    if (currentPlayer.position >= MaxLength)
                    {
                        Console.WriteLine($"{currentPlayer.name} has won the game!");
                        gameEnded = true;
                    }
                    else
                    {
                        var toCut = CheckToCut(currentPlayer);
                        if (!toCut.Cut)
                        {
                            playerQueue.Enqueue(currentPlayer);
                        }
                        else
                        {
                            foreach (var cutPlayer in toCut.multiplePlayers)
                            {
                                Console.WriteLine($"{cutPlayer.name} has been cut!");
                            }
                            // Re-enqueue the current player if they were not cut
                            playerQueue.Enqueue(currentPlayer);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    currentPlayer.ResetPosition();
                    playerQueue.Enqueue(currentPlayer);
                }

                Console.WriteLine("Press 'e' or 'exit' to end the game, or any other key to continue.");
                var input = Console.ReadLine();
                if (input.Equals("e", StringComparison.OrdinalIgnoreCase) || input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    gameEnded = true;
                }
            }
        }

        public void StartGame()
        {
            StartGame_();
        }
    }
}
