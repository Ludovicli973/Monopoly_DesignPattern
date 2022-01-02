using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    class PlayerFacade
    {
        InJailCheck inJailChecker;
        DoubleCheck doubleChecker;
        ThirdFailDoubleCheck thirdFailDoubleChecker;

        public PlayerFacade()
        {
            this.inJailChecker = new InJailCheck();
            this.doubleChecker = new DoubleCheck();
            this.thirdFailDoubleChecker = new ThirdFailDoubleCheck();
        }


        // return false when the player can't play again
        // true if he can
        public bool Move(Player _player, Dice _dice)
        {
            bool playAgain = false;

            if (inJailChecker.IsInJail(_player))
            {
                ExitJail(_player, _dice);
            }
            else
            {
                if (doubleChecker.IsDoubleValue(_dice))
                {
                    _player.DoubleCounter++;

                    if (_player.DoubleCounter != 3)
                    {
                        playAgain = true;
                    }
                }
                else
                {
                    _player.DoubleCounter = 0;
                }

                _player.Move(_dice.SumDice);

            }
            return playAgain;
        }


        public void ExitJail(Player _player, Dice _dice)
        {
            if (doubleChecker.IsDoubleValue(_dice))
            {
                _player.Move(_dice.SumDice);
                _player.NotDoubleCounter = 0;
                _player.InJail = false;
            }
            else
            {
                _player.NotDoubleCounter++;

                if (thirdFailDoubleChecker.FailedThirdDouble(_player))
                {
                    _player.Move(_dice.SumDice);
                    _player.NotDoubleCounter = 0;
                    _player.InJail = false;
                }
            }
        }
    }
}
