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
            Console.WriteLine("How many players are you ?");
            int nbPlayers;

            bool correct = int.TryParse(Console.ReadLine(), out nbPlayers);

            while (!correct || nbPlayers < 2)
            {
                Console.WriteLine("Incorrect, try again :");
                correct = int.TryParse(Console.ReadLine(), out nbPlayers);
            }

            for(int i=0;i<nbPlayers;i++)
            {
                Console.WriteLine("T");
            }
            Console.ReadKey();
        }
    }
}
