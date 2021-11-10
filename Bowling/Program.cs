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
            List<int> numbers = new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 10 };
            for (int i = 0; i < numbers.Count; i++)
            {
                game.roll(numbers[i]);
          
            }

            Console.WriteLine(game.score());

        }
    }
}
