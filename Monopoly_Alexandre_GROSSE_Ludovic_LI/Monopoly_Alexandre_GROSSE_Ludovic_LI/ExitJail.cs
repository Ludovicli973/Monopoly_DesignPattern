using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public class ExitJail
    {
        public bool TryExitJail(Player p,Dice d)
        {
            Move m = new Move();
            if (d.IsDoubleDice() || p.NotDoubleDice_count==3)   // If the player makes double dice or has failed to make double dice for 3 rounds, he's free and move
            {
                p.NotDoubleDice_count = 0;
                p.InJail = false;
                m.MovePlayer(p, d);
            }
            else                                                // If he doesn't make a double and didn't fail to make double dice for 3 rounds, we increase by 1 the number of notdoubledice_count 
            {
                p.NotDoubleDice_count++;
            }
            return false;
        }
    }
}
