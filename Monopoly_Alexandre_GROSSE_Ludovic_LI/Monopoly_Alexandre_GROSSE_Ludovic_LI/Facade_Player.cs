﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public class Facade_Player
    {
        GoToJail _goToJail;
        ExitJail _exitJail;
        Move _move;

        public Facade_Player()
        {
            _goToJail = new GoToJail();
            _exitJail = new ExitJail();
            _move = new Move();
        }

        public bool MakeMove(Player player, Dice dice)
        {
            bool canPlayAgain = false;
            if (player.InJail)   // If the player is in jail, we try to free him
            {
                canPlayAgain = _exitJail.TryExitJail(player, dice); // Returns false in any case, because a player can't play a second time after he leaves jail
            }
            else                // If the player is not in jail, we move him
            {
                if (dice.IsDoubleDice()) // If the player rolls double dice
                {
                    player.DoubleDice_count++;  // We increase the number of doubledice_count of the player
                    if (player.DoubleDice_count == 3)   // If he did 3 doubles, he goes to jail
                    {
                        canPlayAgain = _goToJail.PlayerGoesToJail(player);  // Returns false in any case, because a player can't play a second time after going to jail
                    }
                    else                                // If he did 1 or 2 doubles, he just moves
                    {
                        canPlayAgain = _move.MovePlayer(player,dice);       // Makes a player move and returns true or false if he can move
                    }
                }
                else                    // If the player is not in jail and doesn't roll double dice, he just moves
                {
                    canPlayAgain = _move.MovePlayer(player, dice);          // Returns false because he didn't make a double dice
                }
            }
            return canPlayAgain;
        }
    }
}
