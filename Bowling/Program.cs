using System;
using Bowling;

namespace Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            Bowling game = new Bowling();
            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);
            game.roll(10);




            Console.WriteLine(game.score());

        }
    }
}
