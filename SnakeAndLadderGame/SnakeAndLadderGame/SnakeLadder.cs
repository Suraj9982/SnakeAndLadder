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
        public int Player_Position = 0;
        Random random = new Random();
        public int Dieroll()
        {
            int dienumber = random.Next(1, 7);
            return dienumber;
        }
        public void GamePlay()
        {
            while (Player_Position < 100)
            {
                int dienumber = this.Dieroll();
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        this.Player_Position += NO_PLAY;
                        break;
                    case LADDER:
                        this.Player_Position += dienumber;
                        if (Player_Position > 100)
                        {
                            this.Player_Position -= dienumber;
                        }
                        break;
                    case SNAKE:
                        this.Player_Position -= dienumber;
                        if (Player_Position < START_POINT)
                        {
                            this.Player_Position = START_POINT;
                        }
                        break;
                    default:
                        Console.WriteLine("dicenumber should be between 1 to 6");
                        break;
                }
            }
            Console.WriteLine("player position is " + this.Player_Position);
        }
    }
}
