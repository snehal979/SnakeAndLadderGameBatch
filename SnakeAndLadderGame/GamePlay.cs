using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class GamePlay
    {
        //Variable
        int Player_Position = 0;
        const int No_Play = 0, Ladder = 1, Snake = 2;
        int winning_Position =100;
        int Dice_Played_Count = 0;
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
            Dice_Played_Count++;
            return diceRoll;
        }
        /// <summary>
        /// Uc3 Choice Option for the no play,snake,ladder
        /// Uc4 Repeat till the Player reaches the winning position 100.
        /// </summary>
        public void CheckOption()
        {
            string type = "";
            while(Player_Position < winning_Position) 
            {
                int option = random.Next(3);
                switch (option)
                {
                    case No_Play:
                        type ="No_Player";
                        break;
                    case Ladder:
                        Player_Position += DiceRoll();
                        type ="Ladder";
                        //Uc 5 When player position goes to greater than 100 then its automatically break the program 
                        if (Player_Position > winning_Position) // not greater than 100 
                        {
                            Console.WriteLine("Get Second Chance to Win");
                            Player_Position -= DiceRoll();
                            break;
                        }
                        break;
                    case Snake:
                        Player_Position -= DiceRoll();
                        type = "Snake";
                        if(Player_Position < 0) // not less than zero
                        {
                            Player_Position = 0;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                       
                }
                Console.WriteLine("Type ="+type);
                Console.WriteLine("The Player is current position = "+Player_Position);
                Console.WriteLine("---------");
            }     
            Console.WriteLine("Game over ! Player is at winning position {0} ", Player_Position);

            //Uc 6 Report the number of times the dice was played to win the game and also the position after every die role
            Console.WriteLine("Dice played Count for win the Game " + Dice_Played_Count);

        }

        
    }
}
