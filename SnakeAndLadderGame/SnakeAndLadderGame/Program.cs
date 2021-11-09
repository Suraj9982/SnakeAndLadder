using System;

namespace SnakeAndLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to snake ladder game");
            SnakeLadder game = new SnakeLadder();
            game.dieroll();
        }
    }
}
