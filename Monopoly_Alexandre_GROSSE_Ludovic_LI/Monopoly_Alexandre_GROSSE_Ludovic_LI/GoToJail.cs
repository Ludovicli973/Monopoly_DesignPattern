using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public class GoToJail
    {
        public bool PlayerGoesToJail(Player p)
        {
            p.InJail = true;
            p.DoubleDice_count = 0;
            p.Position = 10;
            return false;
        }
    }
}
