using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public class ExitJail
    {
        // This class is part of the facade pattern
        Player p;
        Dice d;

        public ExitJail(Player p,Dice dice)
        {
            this.p = p;
            d = dice;
        }

        /// <summary>
        /// Function that allows you to try to get a player out of jail, either by making a double or by missing 3 double dice in a row
        /// </summary>
        /// <returns>Returns false because in all the cases, the player will not be able to play again afterwards, whether he makes a double or not</returns>
        public bool TryExitJail()
        { 
            Move m = new Move(p,d);
            if (d.IsDoubleDice() || p.NotDoubleDice_count==2)   // If the player makes double dice or has failed to make double dice for 3 rounds, he's free and move
            {
                p.NotDoubleDice_count = 0;
                p.InJail = false;
                m.MovePlayer();
            }
            else                                                // If he doesn't make a double and didn't fail to make double dice for 3 rounds, we increase by 1 the number of notdoubledice_count 
            {
                p.NotDoubleDice_count++;
            }
            return false;
        }
    }
}
