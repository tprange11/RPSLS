using System;

namespace RPSLS
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "The Game of \"Rock Paper Scissors Lizard Spock\"";
            Console.CursorSize = 100;
            Game game = new Game();
            game.Introduction();
            game.GetPlayer();
            game.GetOpponent();
            while (game.GameOver()==false)
            {
                game.PlayMatch();
                Console.ReadLine();
            }
            Console.Clear();
            game.Introduction();
            game.Scoreboard();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t\t\t{0} WINS!!!!", game.GetWinnerName());
            Console.ReadLine();
        }
    }
}
