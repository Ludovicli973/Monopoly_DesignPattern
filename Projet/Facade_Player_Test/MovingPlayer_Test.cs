using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Monopoly_Alexandre_GROSSE_Ludovic_LI;

namespace Facade_Player_Test
{
    [TestClass]
    public class MovingPlayer_Test
    {
        [TestMethod]
        public void MoveForward_twice()
        {
            Player p = new Player("Player1");
            Dice d = new Dice(4, 4);
            Facade_Player facade = new Facade_Player(p, d);
            bool expected=facade.MakeMove();  // Should return true because the player made double dice
            Assert.AreEqual(expected,true);
        }

        [TestMethod]
        public void MoveForward_3times()
        {
            Player p = new Player("Player1");
            Dice d = new Dice(4, 4);
            Facade_Player facade = new Facade_Player(p, d);
            facade.MakeMove();
            Dice d1 = new Dice(1,1);
            Facade_Player facade1 = new Facade_Player(p, d1);
            bool expected = facade1.MakeMove(); // Should return true because the player made only 2 double dice
            Assert.AreEqual(expected, true);
        }

        [TestMethod]
        public void MoveForward_4times()
        {
            Player p = new Player("Player1");
            Dice d = new Dice(4, 4);
            Facade_Player facade = new Facade_Player(p, d);
            facade.MakeMove();
            Dice d1 = new Dice(1, 1);
            Facade_Player facade1 = new Facade_Player(p, d1);
            facade1.MakeMove();
            Dice d2 = new Dice(3, 3);
            Facade_Player facade2 = new Facade_Player(p, d2);
            bool expected=facade2.MakeMove();   // Should return false because he made 3 double dice so he goes to jail
            Assert.AreEqual(expected,false);
        }

        [TestMethod]
        public void GoingToJail()
        {
            Player p = new Player("Player1");
            p.Position = 28;
            Dice d = new Dice(1, 1);
            Facade_Player facade = new Facade_Player(p, d);
            bool expected=facade.MakeMove();
            Assert.AreEqual(expected, false);   // Should be false because he can't play again after going to jail even if he did double dice
        }
    }
}
