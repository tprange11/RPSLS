using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        Player player1 = new Player();
        Player player2 = new Player();
        Score score = new Score();
        int player1Score = 0;
        int player2Score = 0;
        bool gameOver = false;

        public Game()
        {
            
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
        public void PlayGame()
        {
            Console.Clear();
            Introduction();
            Console.WriteLine("\n{0}, What is your gesture?",player1.name);
            player1.GetGesture();
            Console.Clear();
            Introduction();
            Console.WriteLine("\n{0}, What is your gesture?", player2.name);
            player2.GetGesture();
            score.FindWinner(player1.GetGesture(), player2.GetGesture());


        }
        public bool GameOver()
        {
            if (player1Score > 1 || player2Score > 1)
            {
                gameOver = true;
            }
                return gameOver;
        }
        //public void makePeople(Person[] people)
        //{
        //    Person bill = new Person(1, "Bill", "Bill says, 'I'll only play if you give me a million dollars.'", "Bill says, 'Thanks for the cool mill, now I can pay off my gambling debts! I'll play the game now.'");
        //    people[1] = bill;
        //}
    }
}
