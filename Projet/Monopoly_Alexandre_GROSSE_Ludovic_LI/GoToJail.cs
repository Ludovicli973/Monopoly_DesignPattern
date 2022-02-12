using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public class GoToJail
    {
        // This class is part of the facade pattern
        Player p;

        public GoToJail(Player player)
        {
            this.p = player;
        }

        /// <summary>
        /// Function that puts the player in jail
        /// </summary>
        /// <returns>Returns false because he can't play anymore after going to jail</returns>
        public bool PlayerGoesToJail()
        {
            p.InJail = true;
            p.DoubleDice_count = 0;
            p.Position = 10;
            return false;
        }

        
    }
}
