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
        int Player_1_Position = 0, Player_2_Position = 0; // Vaiable for two player
        const int No_Play = 0, Ladder = 1, Snake = 2;
        int winning_Position =100;
        int Dice_Played_Count = 0;
      
        Random random = new Random();
       
        public void Starting_PositionOfPlayer()
        {
            // Uc 1 Starting position 
            /// Uc7 For Two Player
            Console.WriteLine("Let start the game");
            Console.WriteLine("One Player is starting position "+Player_1_Position);
            Console.WriteLine("Second Player is starting position "+Player_2_Position);
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
        /// Ture of Player Using Random Number
        ///  /// Uc7 For Two Player
        /// </summary>
        /// <returns></returns>
        public int PlayerTurn()
        {
            Random random = new Random();
            int turnOfPlayer = random.Next(0, 2);
            return turnOfPlayer;
        }
        /// <summary>
        /// Uc3 Choice Option for the no play,snake,ladder
        /// Uc4 Repeat till the Player reaches the winning position 100.
        /// Uc7 For Two Player
        /// </summary>
        public void CheckOption()
        {
            string type = "";
            while(Player_1_Position < winning_Position && Player_2_Position<winning_Position) 
            {
                int option = random.Next(3);
                switch (option)
                {
                    case No_Play:
                        type ="No_Player";
                        break;
                    case Ladder:
                        if(PlayerTurn() == 1)
                        {
                            //For Player one
                            Console.WriteLine("one_player Play the game");
                            int DicePosition = DiceRoll(); // for the Current player position
                            Player_1_Position += DicePosition;
                            type ="Ladder";
                            
                            //Uc 5 When player position goes to greater than 100 then its automatically break the program 
                            if (Player_1_Position > winning_Position) // not greater than 100 
                            {
                                Console.WriteLine("Get Second Chance to Win");
                                Player_1_Position -= DicePosition;
                                break;
                            }
                        }
                        else
                        {
                            //For Player Second
                            Console.WriteLine("Second_player Play the game");
                            int DicePosition = DiceRoll(); // for the Current player position
                            Player_2_Position += DicePosition;
                            type ="Ladder";
                           
                            //Uc 5 When player position goes to greater than 100 then its automatically break the program 
                            if (Player_2_Position > winning_Position) // not greater than 100 
                            {
                                Console.WriteLine("Get Second Chance to Win");
                                Player_2_Position -= DicePosition;
                                break;
                            }
                        }
                        
                        break;
                    case Snake:
                        if(PlayerTurn() == 1)
                        {
                            Console.WriteLine("one_player Play the game");
                            //For Player ome
                            Player_1_Position -= DiceRoll();
                            type = "Snake";
                            if (Player_1_Position < 0) // not less than zero
                            {
                                Player_1_Position = 0;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Second_player Play the game");
                            //For Player Second
                            Player_2_Position -= DiceRoll();
                            type = "Snake";
                            if (Player_2_Position < 0) // not less than zero
                            {
                                Player_2_Position = 0;
                            }
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                       
                }
                Console.WriteLine("Type ="+type);
                Console.WriteLine("One Player is current position = "+Player_1_Position);
                Console.WriteLine("Second Player is current position = "+Player_2_Position);
                Console.WriteLine("---------");
            }   
            if(Player_1_Position == winning_Position)
            Console.WriteLine("Game over ! one Player is at winning position {0} ", Player_1_Position);
            else
                Console.WriteLine("Game over ! second Player is at winning position {0} ", Player_2_Position);

            //Uc 6 Report the number of times the dice was played to win the game and also the position after every die role
            Console.WriteLine("Dice played Count for win the Game " + Dice_Played_Count);

        }
        
    }
}
