using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public class Move
    {
        GoToJail _goToJail;
        ExitJail _exitJail;

        public Move()
        {
            _goToJail = new GoToJail();
            _exitJail = new ExitJail();
        }

        public bool MovePlayer(Player player,Dice dice)
        {
            bool moved = false;
            if(player.InJail)   // If the player is in jail, we try to free it
            {
                moved=_exitJail.ExitJailCheck(player,dice);
            }
            else
            {
                if(dice.IsDoubleDice())
                {
                    player.DoubleDice_count++;
                }
            }
            return moved;
        }
    }
}
