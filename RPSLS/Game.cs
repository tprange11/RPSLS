using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        Player player1 = new Player();
        Player player2 = new Player();
        bool gameOver = false;

        public Game()
        {
            gameOver = false;
        }
        public string FindWinner(string player1Gesture, string player2Gesture)
        {
            string result = "";
            if (player1Gesture.ToLower() == player2Gesture.ToLower())
            {
                result = "tie";
            }
            else
            {
                switch ((player1Gesture + player2Gesture).ToLower())
                {
                    case "rockscissors":
                    case "scissorspaper":
                    case "paperrock":
                    case "rocklizard":
                    case "lizardspock":
                    case "spockscissors":
                    case "scissorslizard":
                    case "lizardpaper":
                    case "paperspock":
                    case "spockrock":
                        result = "player1";
                        player1.gamesWon += 1;
                     
                        break;
                    default:
                        result = "player2";
                        player2.gamesWon += 1;
                        break;
                }
            }
            return result;
        }
        public void Introduction()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to a game of \"Rock, Paper, Scissors, Lizard, Spoke\"!\n" +
                "\tRock crushes Scissors\n\tScissors cuts Paper\n" +
                "\tPaper covers Rock\n\tRock crushes Lizard\n" +
                "\tLizard poisons Spock\n\tSpock smashes Scissors\n" +
                "\tScissors decapitates Lizard\n\tLizard eats Paper\n" +
                "\tPaper disproves Spock\n\tSpock vaporizes Rock\n");
            Console.ForegroundColor = ConsoleColor.White;
       }
        public void GetOpponent()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\tWould you like to play the computer?");
            Console.ForegroundColor = ConsoleColor.Blue;
            switch (Console.ReadLine().ToLower())
            {
                case "no":
                    Console.WriteLine("\nPlayer2:");
                    player2.SetName();
                    break;
                case "yes":
                    player2.isComputer = true;
                    player2.name = "Computer";
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid Response");
                    Console.ForegroundColor = ConsoleColor.White;
                    GetOpponent();
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (player2.isComputer)
            {
                Console.WriteLine("\n\tThe computer wishes you luck!");
            }
        }
        public void GetPlayer()
        {
            Console.WriteLine("\nPlayer1:");
            player1.SetName();
        }
        public string GetWinnerName()
        {
            if (player1.gamesWon > 1)
            {
                return player1.name;
            } else
            {
                return player2.name;
            }
            
        }
        public void PlayMatch()
        {
            string winner;
            Console.Clear();
            Introduction();
            Scoreboard();
            player1.GetGesture();
            Console.Clear();
            Introduction();
            Scoreboard();
            player2.GetGesture();
            winner = FindWinner(player1.gesture, player2.gesture);
            switch (winner)
            {
                case "player1":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\tCongradulations {0}, you won the match!", player1.name);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n\tHit Enter to continue game.");
                    break;
                case "player2":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tYou Lost.:( {0} won the match.", player2.name);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n\tHit Enter to continue game."); break;
                case "tie":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\tTie game.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n\tHit Enter to continue game."); break;
            }
        }
        public bool GameOver()
        {
            if (player1.gamesWon > 1 || player2.gamesWon > 1)
            {
                gameOver = true;
            }
                return gameOver;
        }
        public void Scoreboard()
        {
           Console.WriteLine("================ {0}: {1} ================ {2}: {3} ================", player1.name, player1.gamesWon, player2.name, player2.gamesWon);

        }
    }
}
