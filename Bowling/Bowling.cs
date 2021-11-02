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
        int nextRoll = 0;
        int lastRoll = 0;
        int secondNextRoll = 0;
        int frame = 0;
        int nubRolls = 0;
        bool strike = false;
        bool spare = false;
        int numStrikes = 0;

        public void roll(int pins)
        {
            totalScore += pins;
            nubRolls++;
            {
                if (spare && frame != 10)
                {
                    totalScore += pins;
                    spare = false;
                }

                if (strike && frame != 10)
                {
                    totalScore += pins;
                    numStrikes++;
                    if (numStrikes == 2)
                    {
                        strike = false;
                    }
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
                    frame++;
                }
                else if (nubRolls == 2 && pins + lastRoll == 10)
                {
                    spare = true;
                    nubRolls = 0;
                    frame++;
                }
            }
            lastRoll = pins;
            tenFrame();

        }
        public int score()
        {
            return totalScore;
        }

        public void tenFrame()
        {
            if (frame == 10 && spare)
            {
                Console.Write("You have spare in the last frame. Roll one more time: ");
                int extraSpareScore = Convert.ToInt32(Console.ReadLine());
                totalScore += extraSpareScore;
            }
            else if ((frame == 10 && strike))
            {
                Console.Write("You have string in the last frame. You have two extra rolls: ");
                int extraStrikeScore1 = Convert.ToInt32(Console.ReadLine());
                int extraStrikeScore2 = Convert.ToInt32(Console.ReadLine());
                totalScore += extraStrikeScore1 + extraStrikeScore2;
            }
        }
        
    }
}
