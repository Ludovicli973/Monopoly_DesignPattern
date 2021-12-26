using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    class Dice
    {
        int dice1;
        int dice2;
        int sumDice;

        public Dice()
        {
            dice1 = 1;
            dice2 = 1;
            sumDice = 2;
        }

        #region Getters and setters

        public int Dice1
        {
            get { return dice1; }
            set { dice1 = value ; }
        }

        public int Dice2
        {
            get { return dice2 ; }
            set { dice2 = value; }
        }

        public int SumDice
        {
            get { return sumDice ; }
            set { sumDice = value ; }
        }

        #endregion



        public override string ToString()
        {
            return "First dice : " + dice1 + 
                "\nSecond dice : " + dice2 + 
                "\nSum : " + sumDice;
        }


        public void RollDice()
        {
            Random rnd = new Random();
            dice1 = rnd.Next(1, 7);
            dice2 = rnd.Next(1, 7);
            sumDice = dice1 + dice2;
        }
    }
}
