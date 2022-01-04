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
        int doubleDice_count;       // Useful to know if the player has to go to jail
        int notDoubleDice_count;    // Useful when the player is in jail and tries to get out

        public Player(string name)
        {
            this.name = name;
            position = 0;
            inJail = false;
            doubleDice_count = 0;
            notDoubleDice_count = 0;
        }

        #region Properties

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

        public int DoubleDice_count
        {
            get { return doubleDice_count; }
            set { doubleDice_count = value; }
        }

        public int NotDoubleDice_count
        {
            get { return notDoubleDice_count; }
            set { notDoubleDice_count = value; }
        }

        #endregion

        public override string ToString()
        {
            return "Name : " + name + " | Position : " + position + " | In Jail : " + inJail + " | DoubleDice_count : " + doubleDice_count + " | NotDoubleDice_count : " + notDoubleDice_count;
        }

        public string toStringPosition()
        {
            return "New position : " + position + " | In Jail : " + inJail + " | DoubleDice_count : " + doubleDice_count + " | NotDoubleDice_count : " + notDoubleDice_count;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Player);
        }

        public bool Equals(Player other)
        {
            if (other is null)
            {
                return false;
            }
            else
            {
                return this.GetHashCode() == other.GetHashCode();
            }
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }


        public static bool operator ==(Player player1, Player player2)
        {
            if (player1 is null)
            {
                return player2 is null;
            }

            return player1.Equals(player2);
        }

        public static bool operator !=(Player player1, Player player2)
        {
            return !(player1 == player2);
        }

        
    }
}
