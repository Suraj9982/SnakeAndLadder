using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    class SnakeLadder
    {
        public int Player_Position = 0;
        Random random = new Random();
        public void dieroll()
        {
            int dienumber = random.Next(1, 7);
        }
    }
}
