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
        const int No_Play = 0, Ladder = 1, Snake = 2;
        Random random = new Random();
        public void Starting_PositionOfPlayer()
        { 
            // Uc 1 Starting position 
            Console.WriteLine("Let start the game");
            Console.WriteLine("The Player is starting position "+Player_Position);
        }
        /// <summary>
        /// Uc2 DiceRoll
        /// </summary>
        public int DiceRoll()
        {
            //The Player rolls the die to get a number between 1 to 6. - Use((RANDOM)) to get the number 
            int diceRoll = random.Next(1,7);
            Console.WriteLine("The player get number {0} on DiceRoll",diceRoll);
            return diceRoll;
        }
        /// <summary>
        /// Uc3 Choice Option for the no play,snake,ladder
        /// </summary>
        public void CheckOption()
        {
            int option = random.Next(3);
            switch (option)
            {
                case No_Play:
                    Player_Position = 0;
                    break;
                case Ladder:
                    Player_Position += DiceRoll(); // call the method for diceroll method
                    break;
                case Snake:
                    Player_Position -= DiceRoll(); 
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
            Console.WriteLine("The Player is current position = "+Player_Position);
        }
    }
}
