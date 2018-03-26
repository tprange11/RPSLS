using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        bool isComputer;
        Player player1 = new Player();
        Player player2 = new Player();

        public void Introduction()
        {
            Console.WriteLine("Welcome to a game of Rock, Paper, Scissors, Lizard, Spoke!\n" +
                "\tRock crushes Scissors\n\tScissors cuts Paper\n" +
                "\tPaper covers Rock\n\tRock crushes Lizard\n" +
                "\tLizard poisons Spock\n\tSpock smashes Scissors\n" +
                "\tScissors decapitates Lizard\n\tLizard eats Paper\n" +
                "\tPaper disproves Spock\n\tSpock vaporizes Rock\n" +
                "\nPlayer1:");
            player1.SetName();
            //Console.WriteLine("Your team, {0}, has a game of its life!", player.getTeamName());
            //Console.WriteLine("You must assemble your team and find your van in order to get to the game on time.");
        }
        public void GetOpponent()
        {
            Console.WriteLine("\nWould you like to play the computer?");
            switch (Console.ReadLine().ToLower())
            {
                case "no":
                    isComputer = false;
                    Console.WriteLine("\nPlayer2:");
                    player2.SetName();
                    break;
                case "yes":
                    isComputer = true;
                    break;
                default:
                    Console.WriteLine("\nInvalid Response");
                    GetOpponent();
                    break;
            }
            if (isComputer)
            {
                Console.WriteLine("\nThe computer wishes you luck!");

            }



        }
        public void GameOver()
        {
            //if (player.GetGameWon())
            //{
            //    Console.WriteLine("You win!");
            //}
            //else
            //{
            //    Console.WriteLine("You lost the game. :( :( :(");
            //}
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
        }
        //public void makePeople(Person[] people)
        //{
        //    Person bill = new Person(1, "Bill", "Bill says, 'I'll only play if you give me a million dollars.'", "Bill says, 'Thanks for the cool mill, now I can pay off my gambling debts! I'll play the game now.'");
        //    people[1] = bill;
        //}
    }
}
