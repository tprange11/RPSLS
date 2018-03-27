using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Player : Person
    {
        public bool isComputer;
        public int gamesWon;
        List<string> gestureList = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        string gesture;
        
        public Player()
        {
            isComputer = false;
            gamesWon = 0;
        }

        public int GetGamesWon()
        {
            return gamesWon;
        }
        public string GetGesture()
        {
            if (this.isComputer)
            {
                Random rnd = new Random();
                int index = rnd.Next(gestureList.Count);
                Console.WriteLine("Computer picks " + gestureList[index]);
                gesture = gestureList[index];
            }
            else
            {
                Console.WriteLine("\n{0}, What is your gesture?", name);
                gesture = Console.ReadLine();
                if (ValidateGesture(gesture) == false)
                {
                    GetGesture();
                }
            }

            return gesture;
        }
        public string GetName()
        {
            return name;
        }
        public override void DisplayName()
        {
            Console.WriteLine("Welcome " + name);
        }
        public void SetName()
        {
            Console.Write("What is your name?\n");
            name = Console.ReadLine();
        }
        public bool ValidateGesture(string gesture)
        {
            bool result = gestureList.Contains(gesture.ToLower());
            return result;
        }


    }
}
