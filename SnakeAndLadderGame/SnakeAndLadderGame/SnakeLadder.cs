using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    class SnakeLadder
    {
        public int player_position = 0;
        Random random = new Random();
        public int Dieroll()
        {
            int dienumber = random.Next(1, 7);
            return dienumber;
        }
    }
}
