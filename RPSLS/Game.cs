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
            if (player1Gesture == player2Gesture)
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
            Console.WriteLine("Welcome to a game of Rock, Paper, Scissors, Lizard, Spoke!\n" +
                "\tRock crushes Scissors\n\tScissors cuts Paper\n" +
                "\tPaper covers Rock\n\tRock crushes Lizard\n" +
                "\tLizard poisons Spock\n\tSpock smashes Scissors\n" +
                "\tScissors decapitates Lizard\n\tLizard eats Paper\n" +
                "\tPaper disproves Spock\n\tSpock vaporizes Rock\n");
       }
        public void GetOpponent()
        {
            Console.WriteLine("\nWould you like to play the computer?");
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
                    Console.WriteLine("\nInvalid Response");
                    GetOpponent();
                    break;
            }
            if (player2.isComputer)
            {
                Console.WriteLine("\nThe computer wishes you luck!");

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
        public void PlayGame()
        {
            string winner;
            Console.Clear();
            Introduction();
            player1.GetGesture();
            Console.Clear();
            Introduction();
            player2.GetGesture();
            winner = FindWinner(player1.gesture, player2.gesture);
            switch (winner)
            {
                case "player1":
                    Console.WriteLine("\nCongradulations {0}, you won the match! \n\nHit Enter to continue game.", player1.name);
                    break;
                case "player2":
                    Console.WriteLine("\nYou Lost.:( {0} won the match. \n\nHit Enter to continue game.", player2.name);
                    break;
                case "tie":
                    Console.WriteLine("\nTie game. \n\nHit Enter to replay..");
                    break;
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
    }
}
