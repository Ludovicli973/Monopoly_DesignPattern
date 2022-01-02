using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public class Dice
    {
        int dice1;
        int dice2;
        int sumDice;
        Random rnd;

        public Dice()
        {
            this.dice1 = -1;
            this.dice2 = -2;
            this.sumDice = -3;
            this.rnd = new Random();
        }

        public int Dice1
        {
            get { return dice1; }
            set { dice1 = value; }
        }

        public int Dice2
        {
            get { return dice2; }
            set { dice2 = value; }
        }

        public int SumDice
        {
            get { return sumDice; }
            set { sumDice = value; }
        }

        public override string ToString()
        {
            return "Die 1 : "+dice1+ " Die 2 : "+dice2+" Sum dice : "+sumDice;
        }


        public void RollDice()
        {
            dice1 = rnd.Next(1, 7);
            dice2 = rnd.Next(1, 7);
            sumDice = dice1 + dice2;
        }

        public bool DoubleDice()
        {
            return dice1 == dice2;
        }
    }
}
