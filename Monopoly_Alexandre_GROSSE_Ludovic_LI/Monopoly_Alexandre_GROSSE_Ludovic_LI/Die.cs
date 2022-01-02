using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    class Die
    {
        int _die;
        Random rnd=new Random();

        public Die()
        {
            _die = 0;
        }

        public int _Die
        {
            get { return _die; }
            set { _die = value; }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Die);
        }

        public bool Equals(Die d)
        {
            if (d is null)
            {
                return false;
            }
            else
            {
                return this.GetHashCode() == d.GetHashCode();
            }
        }

        public override int GetHashCode()
        {
            return _die.GetHashCode();
        }

        public static bool operator == (Die die1,Die die2)
        {
            return die1.Equals(die2);
        }

        public static bool operator != (Die die1,Die die2)
        {
            return !(die1==die2);
        }


        public override string ToString()
        {
            return "Die : "+_die;
        }


        public void RollDie()
        {
            _die = rnd.Next(1, 7);
        }
    }
}
