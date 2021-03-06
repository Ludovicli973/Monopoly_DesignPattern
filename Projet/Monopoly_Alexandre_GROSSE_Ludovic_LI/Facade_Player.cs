using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public class Facade_Player
    {
        // This class corresponds to a facade pattern

        Player player;
        Dice dice;
        GoToJail _goToJail;
        ExitJail _exitJail;
        Move _move;

        public Facade_Player(Player p,Dice d)
        {
            player = p;
            dice = d;
            _goToJail = new GoToJail(player);
            _exitJail = new ExitJail(player,dice);
            _move = new Move(player,dice);
        }

        /// <summary>
        /// Function that allows a player to move, automatically update the player attributes (doubleDice_count, inJail ...)
        /// </summary>
        /// <returns>Returns true if the player can play again in the same turn, false otherwise</returns>
        public bool MakeMove()
        {
            bool canPlayAgain = false;
            if (player.InJail)   // If the player is in jail, we try to free him
            {
                canPlayAgain = _exitJail.TryExitJail();
            }
            else                // If the player is not in jail, we move him
            {
                if (dice.IsDoubleDice()) // If the player rolls double dice
                {
                    player.DoubleDice_count++;  // We increase the number of doubledice_count of the player
                    if (player.DoubleDice_count == 3)   // If he did 3 doubles, he goes to jail
                    {
                        canPlayAgain = _goToJail.PlayerGoesToJail();  
                    }
                    else                                // If he did 1 or 2 doubles, he just moves
                    {
                        canPlayAgain = _move.MovePlayer();       
                    }
                }
                else                    // If the player is not in jail and doesn't roll double dice, he just moves
                {
                    canPlayAgain = _move.MovePlayer();          
                }
            }
            return canPlayAgain;
        }
    }
}
