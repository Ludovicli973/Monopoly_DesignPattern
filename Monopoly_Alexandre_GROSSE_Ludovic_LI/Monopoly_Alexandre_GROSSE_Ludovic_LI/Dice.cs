using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public class Dice
    {
        int die1;
        int die2;
        int sumDice;
        Random r=new Random();

        public Dice()
        {
            die1 = -1;
            die2 = -2;
            sumDice = -3;
        }

        public Dice(int value1,int value2)
        {
            this.die1 = value1;
            this.die2 = value2;
            this.sumDice = value1 + value2;
        }

        public int Die1
        {
            get { return this.die1; }
            set { this.die1 = value; }
        }

        public int Die2
        {
            get { return this.die2; }
            set { this.die2 = value; }
        }

        public int SumDice
        {
            get { return sumDice; }
            set { sumDice = value; }
        }

        public override string ToString()
        {
            return "First dice : " + die1 +"\nSecond dice : " + die2 +"\nSum : " + sumDice;
        }

        public void RollDice()
        {
            die1 = r.Next(1, 7);
            die2 = r.Next(1, 7);
            sumDice = die1 + die2;
        }

        public bool IsDoubleDice()
        {
            return die1 == die2;
        }
    }
}
