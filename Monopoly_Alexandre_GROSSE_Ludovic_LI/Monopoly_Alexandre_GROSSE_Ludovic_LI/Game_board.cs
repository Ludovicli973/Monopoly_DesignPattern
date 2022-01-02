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

    }
}
