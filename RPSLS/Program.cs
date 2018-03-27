using System;

namespace RPSLS
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Game game = new Game();
            game.Introduction();
            game.GetPlayer();
            game.GetOpponent();
            while (game.GameOver()==false)
            {
                game.PlayGame();
                Console.ReadLine();
            }
            
            Console.WriteLine("{0} WINS!!!!", game.GetWinnerName());
            Console.ReadLine();
        }
    }
}
