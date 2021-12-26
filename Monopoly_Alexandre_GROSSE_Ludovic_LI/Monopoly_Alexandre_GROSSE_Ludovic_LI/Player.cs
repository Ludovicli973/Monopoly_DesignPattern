using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public class Player
    {
        string name;
        int position;
        bool inJail;

        public Player(string name)
        {
            this.name = name;
            this.position = 0;
            this.inJail = false;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        public bool InJail
        {
            get { return inJail; }
            set { inJail = value; }
        }

        public override string ToString()
        {
            return "Name : " + name + " Position : " + position + " In Jail : " + inJail;
        }
    }
}
