using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice d = new Dice();
            d.RollDice();
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
