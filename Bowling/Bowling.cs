using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Bowling
    {
        int totalScore = 0;
        int lastRoll = 0;
        int oneBeforeLast = 0;
        int frame = 0;
        int nubRolls = 0;
        bool strike = false;
        bool spare = false;
        bool secondStrike = false;
        bool game = true;

        public void roll(int pins)
        {
            if (game)
            {
                totalScore += pins;
                nubRolls++;
                {
                    // Add bonus poinst from spare
                    if (spare && frame < 10)
                    {
                        totalScore += pins;
                        spare = false;
                    }
                    // Add bonus points from strike
                    if (strike && frame < 10)
                    {
                        totalScore += pins;
                    }

                    // Check of activate bonus points for second strike
                    if (((strike && oneBeforeLast == 10 && nubRolls != 2)) && frame <=10)
                    {
                        totalScore += pins;
                    }
                    // Add points from second active strike
                    //if (strike && secondStrike)
                    //{
                        //totalScore += pins;

                        //secondStrike = false;
                    //}

                    // Stop add bonus points for a strike
                    if (strike && lastRoll != 10)
                    {
                        strike = false;
                    }

                    // Activate strike bonus
                    if (pins == 10 && nubRolls == 1)
                    {
                        strike = true;
                        frame++;
                        nubRolls = 0;
                    }
                    // Add points if sum of rols in one frame is smaller than 10
                    else if (nubRolls == 2 && pins + lastRoll < 10)
                    {
                        nubRolls = 0;
                        strike = false;
                        frame++;
                    }
                    // Activate spare
                    else if (nubRolls == 2 && pins + lastRoll == 10)
                    {
                        spare = true;
                        nubRolls = 0;
                        frame++;
                    }
                }

                oneBeforeLast = lastRoll;
                lastRoll = pins;

                // End a game if is not posible to make 11 or 12 rol
                if ( frame == 10 && (!strike && !spare))
                    {
                       game = false;
                    } 
                else if (frame == 11 && !strike)
                {
                    game = false;
                }
                else if (frame == 12)
                {
                    game = false;
                }
            }
        }
        public int score()
        {
            return totalScore;
        }
        
    }
}
