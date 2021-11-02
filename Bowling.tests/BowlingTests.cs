using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bowling;
using Xunit;

namespace Bowling.tests
{
    public class BowlingTests
    {
        BowlingTests game = new BowlingTests();
        public void Game_BadRolls()
        {
            // Arrange
            int expected = 0;

            //Act
            List<int> BadRolls = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < BadRolls.Count(); i++)
                {
                    game.roll(i);
                }
                
        }
    }
}
