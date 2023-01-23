using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class GamePlay
    {
        int Player_Position = 0;
        public void Starting_PositionOfPlayer()
        { 
            // Uc 1 Starting position 
            Console.WriteLine("Let start the game");
            Console.WriteLine("The Player is starting position "+Player_Position);
        }
    }
}
