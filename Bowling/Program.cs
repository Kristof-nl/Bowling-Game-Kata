using System;
using Bowling;
using System.Linq;
using System.Collections.Generic;

namespace Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            Bowling game = new Bowling();
            List<int> numbers = new List<int>() { 10, 10, 10, 10, 10, 10, 10, 10, 10, 1, 9, 1 };
            for (int i = 0; i < numbers.Count; i++)
            {
                game.roll(numbers[i]);

            }

            Console.WriteLine(game.score());

            int frame = 10;
            bool strike = true;
            bool spare = false;


            if (frame == 10)
            {
                if (!strike && !spare)
                {
                    Console.WriteLine("Działa");
                }
            }
        } }
}
