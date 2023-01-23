namespace SnakeAndLadderGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake And Ladder Game ");
            //Uc1 Starting position at zero
            GamePlay gamePlay = new GamePlay();
            gamePlay.Starting_PositionOfPlayer();
            gamePlay.DiceRoll();
            Console.ReadLine();
        }
    }
}