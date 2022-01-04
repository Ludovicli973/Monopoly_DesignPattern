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
            Board_game game = Board_game.GetInstance();
            game.StartGame();
            game.PlayingGame();
            // 
            Console.ReadKey();
        }
    }
}
