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
            
            //Console.WriteLine("How many players are you ?");
            //int nbPlayers;

            //bool correct = int.TryParse(Console.ReadLine(), out nbPlayers);

            //while (!correct || nbPlayers < 2)
            //{
            //    Console.WriteLine("Incorrect, try again :");
            //    correct = int.TryParse(Console.ReadLine(), out nbPlayers);
            //}

            //List<Player> players = new List<Player>();
            //for (int i=1;i<=nbPlayers;i++)
            //{
            //    Console.WriteLine("Enter a name for player "+i+":");
            //    players.Add(new Player(Console.ReadLine()));
            //}
            //Game_board g = Game_board.GetInstance(players);
            //Console.ReadKey();

            Die d1 = new Die();
            d1.RollDie();
            Die d2 = new Die();
            d2.RollDie();
            Console.WriteLine(d1);
            Console.WriteLine(d2);
             Console.Write(d1 == d2);
            Console.ReadKey();
        }
    }
}
