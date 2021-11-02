using System;
using Bowling;

namespace Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            Bowling game = new Bowling();
            game.roll(9);
            game.roll(1);
            game.roll(9);
            game.roll(1);
            game.roll(9);
            game.roll(1);
            game.roll(9);
            game.roll(1);
            game.roll(9);
            game.roll(1);
            game.roll(9);
            game.roll(1);
            game.roll(9);
            game.roll(1);
            game.roll(9);
            game.roll(1);
            game.roll(9);
            game.roll(1);
            game.roll(9);
            game.roll(1);




            Console.WriteLine(game.score());

        }
    }
}
