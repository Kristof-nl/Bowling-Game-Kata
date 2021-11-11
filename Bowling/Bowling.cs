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

        public void roll(int pins)
        {
            totalScore += pins;
            nubRolls++;
            {
                if (spare)
                {
                    totalScore += pins;
                    spare = false;
                }

                if (strike)
                {
                    totalScore += pins;
                }

                if (strike && oneBeforeLast == 10 && nubRolls != 2)
                {
                    secondStrike = true;
                }

                if (strike && secondStrike)
                {
                    totalScore += pins;

                    secondStrike = false;
                }

                if (strike && lastRoll != 10)
                {
                    strike = false;
                }
                

                if (pins == 10 && nubRolls == 1)
                {
                    strike = true;
                    frame++;
                    nubRolls = 0;
                }
                else if (nubRolls == 2 && pins + lastRoll < 10)
                {
                    nubRolls = 0;
                    strike = false;
                    frame++;
                }
                else if (nubRolls == 2 && pins + lastRoll == 10)
                {
                    spare = true;
                    nubRolls = 0;
                    frame++;
                }

                // For extra 20 points in the first frame (if 3 strikes in a row)
                //if (frame == 3 && pins == 10 && totalScore == 50)
                //{
                  //totalScore += 20;
                //}

            }
            oneBeforeLast = lastRoll;
            lastRoll = pins;
            tenFrame(pins);

        }
        public int score()
        {
            return totalScore;
        }

        public void tenFrame(int pins)
        {
            if (frame == 10 && spare)
            {
               // Comment to make test
               //Console.Write("You have spare in the last frame. Roll one more time: ");
               //int extraSpareScore = Convert.ToInt32(Console.ReadLine());
               //totalScore += extraSpareScore;

               // Uncomment to make test
               totalScore += pins;
            }
            else if ((frame == 10 && strike))
            {
                // Comment to make test
                //Console.Write("You have strike in the last frame. You have two extra rolls: ");
               // int extraStrikeScore1 = Convert.ToInt32(Console.ReadLine());
                //int extraStrikeScore2 = Convert.ToInt32(Console.ReadLine());
                //totalScore += extraStrikeScore1 + extraStrikeScore2;

                // Uncomment to make test
                totalScore += pins;
                totalScore += pins;

            }

        }
        
    }
}
