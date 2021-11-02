using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    class Bowling
    {
        int totalScore = 0;
        int lastRoll = 0;
        int secondLastRoll = 0;
        int frame = 0;
        int nubRolls = 0;

        public void roll(int pins)
        {
            totalScore += pins;
            nubRolls++;
            {
                if (pins == 10 && nubRolls == 1)
                {
                    totalScore += lastRoll + secondLastRoll;
                    frame++;
                    nubRolls = 0;
                }
                else if (nubRolls == 2 && pins + lastRoll < 10)
                {
                    nubRolls = 0;
                    frame++;
                }
                else if (nubRolls == 2 && pins + lastRoll == 10)
                {
                    totalScore += lastRoll;
                    nubRolls = 0;
                    frame++;
                }
            }
            secondLastRoll = lastRoll;
            lastRoll = pins;

        }
        public int score()
        {
            return totalScore;
        }
    }
}
