using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    class SnakeLadder
    {
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2,WIN=100,START_POINT=0;
        public int player_position = 0;
        Random random = new Random();
        public int Dieroll()
        {
            int dienumber = random.Next(1, 7);
            return dienumber;
        }
        public void GamePlay()
        {
            while (player_position < 100)
            {
                int dicenumber = this.Dieroll();
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        this.player_position += NO_PLAY;
                        break;
                    case LADDER:
                        this.player_position += dicenumber;
                        break;
                    case SNAKE:
                        this.player_position -= dicenumber;
                        if (player_position < START_POINT)
                        {
                            this.player_position = START_POINT;
                        }
                        break;
                    default:
                        Console.WriteLine("dicenumber should be between 1 to 6");
                        break;
                }
            }
            Console.WriteLine("player position is " + this.player_position);
        }
    }
}
