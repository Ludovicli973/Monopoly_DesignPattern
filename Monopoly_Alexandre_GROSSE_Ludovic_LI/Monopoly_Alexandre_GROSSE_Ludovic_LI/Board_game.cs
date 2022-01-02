using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public sealed class Board_game
    {
        static Board_game _instance;
        List<Player> players = new List<Player>();
        Dice d = new Dice();

        private Board_game() 
        {
        }

        public static Board_game GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Board_game();
            }
            return _instance;
        }

        public bool AddPlayer(string playerName)
        {
            Player newPlayer = new Player(playerName);
            bool playerAdded = false;

            if (!players.Contains(newPlayer))
            {
                players.Add(newPlayer);
                playerAdded = true;
            }
            return playerAdded;
        }

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
            int turnNumber = 1;
            bool playAgain;
            Move _move = new Move();
            while (true)
            {
                Console.WriteLine("\n\n\n######################## TURN N°" + turnNumber + " ########################");

                foreach (Player p in players)
                {
                    Console.WriteLine(p.Name + ", you're at position " + p.Position);
                    Console.WriteLine("It's your turn, press any key to roll the dice :");
                    Console.ReadKey();

                    do
                    {
                        d.RollDice();
                        Console.WriteLine(d);
                        playAgain = _move.MovePlayer(p,d);
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
