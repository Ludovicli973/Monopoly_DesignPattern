using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public sealed class Game_board
    {
        List<Player> players;
        Dice _dice;
        static Game_board _instance;
        bool end;
        int turnNumber;

        private Game_board()
        {
            this.players = new List<Player>();
            this._dice = new Dice();
            this.end = false;
            this.turnNumber = 1;
        }

        public static Game_board GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Game_board();
            }
            return _instance;
        }

        public override string ToString()
        {
            string msg = "Players :\n";
            foreach (Player p in players)
            {
                msg += p + "\n";
            }
            return msg;
        }


        // Adding a new player
        // return true when the player is added, false when he isn't
        public bool AddPlayer(string namePlayer)
        {
            Player newPlayer = new Player(namePlayer);

            if (!players.Contains(newPlayer))
            {
                players.Add(newPlayer);
                return true;
            }
            return false;
        }


        // Initializing the players
        public void StartGame()
        {
            Console.WriteLine("Hello and welcome to the Monopoly 2.0 !\n");
            Console.WriteLine("How many players are you ?");

            bool correct = int.TryParse(Console.ReadLine(), out int nbPlayers);

            while (!correct || nbPlayers < 2)
            {
                Console.WriteLine("Incorrect, try again :");
                correct = int.TryParse(Console.ReadLine(), out nbPlayers);
            }

            for (int i = 1; i <= nbPlayers; i++)
            {
                bool playerAdded = false;

                while (!playerAdded)
                {
                    Console.WriteLine("Enter a name for player " + i + ":");
                    playerAdded = AddPlayer(Console.ReadLine());
                }
            }

            Console.WriteLine("Let's start the game !");
        }


        public void PlayingGame()
        {
            while (!end)
            {
                Console.WriteLine("\n\n\n######################## TURN N°" + turnNumber + " ########################");

                bool playAgain;

                foreach (Player p in players)
                {
                    Console.WriteLine(p.Name + ", you're at position " + p.Position);
                    Console.WriteLine("It's your turn, press any key to roll the dice :");
                    Console.ReadKey();

                    do
                    {
                        _dice.RollDice();
                        Console.WriteLine(_dice);

                        playAgain = facade.Move(p, _dice);
                        Console.WriteLine(p + "\n");

                        if (playAgain)
                        {
                            Console.WriteLine("You made a double ! Press any key to roll the dice again :");
                            Console.ReadKey();
                        }

                    } while (playAgain);

                }

                turnNumber++;
            }
        }
    }
}
