using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public class Move
    {
        // This class is part of the facade pattern
        Player p;
        Dice d;

        public Move(Player player,Dice dice)
        {
            this.p = player;
            d = dice;
        }

        /// <summary>
        /// Function that allows you to move a player
        /// </summary>
        /// <returns>Returns true if a player can play again, false otherwise</returns>
        public bool MovePlayer()
        {
            bool canPlayAgain = d.IsDoubleDice();   // If the player has made double dice, he can play again, otherwise he cannot
            int tempPosition = p.Position;
            tempPosition += d.SumDice;
            if (tempPosition > 39)
            {
                tempPosition -= 40;
            }

            if (tempPosition == 30)
            {
                GoToJail _goToJail = new GoToJail(p);
                canPlayAgain = _goToJail.PlayerGoesToJail();    // If he goes to jail, he can't play again so canPlayAgain will be false
                tempPosition = 10;
            }
            p.Position = tempPosition;
            return canPlayAgain;
        }
    }
}
