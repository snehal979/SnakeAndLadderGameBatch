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
        /// <summary>
        /// Uc2 DiceRoll
        /// </summary>
        public void DiceRoll()
        {
            //The Player rolls the die to get a number between 1 to 6. - Use((RANDOM)) to get the number
            Random random = new Random();
            int diceRoll = random.Next(1,7);
            Console.WriteLine("The player get number {0} on DiceRoll",diceRoll);
        }
    }
}
