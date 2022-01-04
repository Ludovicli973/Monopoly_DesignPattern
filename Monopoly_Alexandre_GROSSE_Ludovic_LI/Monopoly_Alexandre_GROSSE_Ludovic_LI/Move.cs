using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public class Move
    {
        public bool MovePlayer(Player p, Dice d)
        {
            bool canMoveNextTurn = d.IsDoubleDice();
            int tempPosition = p.Position;
            tempPosition += d.SumDice;

            if (tempPosition > 39)
            {
                tempPosition -= 40;
            }

            if (tempPosition == 30)
            {
                GoToJail _goToJail = new GoToJail();
                canMoveNextTurn = _goToJail.PlayerGoesToJail(p);
                tempPosition = 10;
            }
            p.Position = tempPosition;
            return canMoveNextTurn;
        }
    }
}
