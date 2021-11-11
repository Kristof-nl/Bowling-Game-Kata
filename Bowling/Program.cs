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
            List<int> numbers = new List<int>() { 10, 1, 7, 2, 8, 1, 9, 1, 3, 10, 3, 2, 7, 1, 4, 1, 3, 3 };
            for (int i = 0; i < numbers.Count; i++)
            {
                game.roll(numbers[i]);
          
            }

            Console.WriteLine(game.score());

        }
    }
}
