using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public sealed class Board_game:IObserver
    {
        // This class corresponds to a singleton pattern, that's why it is sealed and the constructor is private

        static Board_game _instance;    // Corresponds to the only possible game board to instantiate
        List<Player> players = new List<Player>();
        Dice d = new Dice();

        private Board_game() { }    // The constructor is private because it's a singleton

        /// <summary>
        /// Function to instantiate an instance (only one) of the Game_board class
        /// </summary>
        /// <returns>Returns the board game</returns>
        public static Board_game GetInstance() 
        {
            if (_instance == null)
            {
                _instance = new Board_game();
            }
            return _instance;
        }

        /// <summary>
        /// Function to add players to the game
        /// </summary>
        /// <param name="playerName">Name of the player</param>
        /// <returns>Returns true if the player has been added, false otherwise</returns>
        public bool AddPlayer(string playerName)
        {
            Player newPlayer = new Player(playerName.ToUpper());
            bool playerAdded = false;

            if (!players.Contains(newPlayer))
            {
                players.Add(newPlayer);
                playerAdded = true;
            }
            return playerAdded;
        }

        /// <summary>
        /// function that allows you to create the list of players of the game
        /// </summary>
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

            Console.Clear();
            Console.WriteLine("Let's start the game !\n");
        }

        /// <summary>
        /// Function that allows the game to run
        /// </summary>
        public void PlayingGame()
        {
            int turnNumber = 1;
            bool playAgain;
            while (true)
            {
                Console.WriteLine("######################################### TURN N°" + turnNumber + " #########################################\n");

                foreach (Player p in players)
                {
                    
                    Console.WriteLine(p.Name + "\nCurrent position : " + p.Position);
                    Console.WriteLine("It's your turn, press any key to roll the dice :\n");
                    Console.ReadKey();

                    do
                    {
                        d.RollDice();
                        Console.WriteLine(d);
                        Facade_Player _facade = new Facade_Player(p,d);
                        playAgain = _facade.MakeMove();
                        Console.WriteLine("\n"+p.toStringPosition() + "\n");

                        if (playAgain)
                        {
                            Console.WriteLine("You made a double ! Press any key to roll the dice again :\n");
                            Console.ReadKey();
                        }

                    } while (playAgain);

                    p.DoubleDice_count = 0;
                    Console.WriteLine("_____________________________________________________________________________________________\n");
                }
                turnNumber++;
            }
        }

        /// <summary>
        /// Function that indicates when a player goes to jail, because this class is also part of an observer pattern
        /// </summary>
        /// <param name="o">Player who goes to jail</param>
        public void Update(IObservable o)
        {
            Player p = (Player)o;
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(p.Name + " is going to jail");
            Console.WriteLine("---------------------------------------------------------------------------------------------\n");
        }

        /// <summary>
        /// Function that adds the board_game instance to the list of IObserver located in the Player class
        /// </summary>
        public void Add_BoardGame_toPlayers()
        {
            foreach (Player p in players)
            {
                p.Attach(this);
            }
        }
    }
}
