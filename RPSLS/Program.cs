using System;

namespace RPSLS
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Score score = new Score();
            Game game = new Game();
            game.Introduction();
            game.GetPlayer();
            game.GetOpponent();
            while (game.GameOver()==false)
            {
                game.PlayGame();
                
            }
            
            Console.ReadLine();

        }
    }
}
