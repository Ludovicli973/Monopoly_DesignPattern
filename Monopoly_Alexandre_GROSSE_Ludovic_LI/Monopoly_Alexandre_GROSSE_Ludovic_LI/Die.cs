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
        Random rnd;

        public Die()
        {
            _die = 1;
            rnd=new Random();
        }

        #region Getters and setters

        public int _Die
        {
            get { return _die; }
            set { _die = value ; }
        }

        #endregion

        public static bool operator ==(Die 1,Die 2)
        {
            return true;
        }

        public static bool operator !=(Die 1,Die 2)
        {
            return true;
        }


        public override string ToString()
        {
            return "Die :"+_die;
        }


        public void RollDice()
        {
            _die = rnd.Next(1, 7);
        }
    }
}
