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
            Die d1 = new Die();
            d1.RollDie();
            Console.WriteLine(d1);
            Die d2 = new Die();
            d2.RollDie();
            Console.WriteLine(d2);
            Console.Write(d1 == d2);
            Console.ReadKey();
        }
    }
}
