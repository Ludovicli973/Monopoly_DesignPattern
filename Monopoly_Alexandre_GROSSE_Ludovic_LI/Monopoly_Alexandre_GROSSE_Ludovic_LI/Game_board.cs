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

        private Game_board(List<Player>players) 
        {
            this.players = players;
            this._dice = new Dice();
        }

        public static Game_board GetInstance(List<Player> players)
        {
            if(_instance==null)
            {
                _instance = new Game_board(players);
            }
            return _instance;
        }

        public override string ToString()
        {
            string msg = "Players :\n";
            foreach (Player p in players)
            {
                msg += p+"\n";
            }
            return msg;
        }
    }
}
