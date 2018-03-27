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
        public string gesture;
        
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
            if (isComputer)
            {
                Random rnd = new Random();
                int index = rnd.Next(gestureList.Count);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\tComputer picks " + gestureList[index]);
                Console.ForegroundColor = ConsoleColor.White;
                gesture = gestureList[index];
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n\t{0}, What is your gesture?", name);
                Console.ForegroundColor = ConsoleColor.Blue;
                //gesture = Console.ReadLine();
                gesture = "";
                ConsoleKeyInfo key;

                do
                {
                    key = Console.ReadKey(true);

                    // Backspace Should Not Work
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        gesture += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("\b");
                    }
                }
                // Stops Receving Keys Once Enter is Pressed
                while (key.Key != ConsoleKey.Enter);
                //gesture = gesture.Substring(0, (gesture.Length - 1));
                
                Console.ForegroundColor = ConsoleColor.White;
                if (ValidateGesture(gesture) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t\"{1}\" Invalid Gesture.:( \n\n\tUse one of the following.\n\t{0}", String.Join(", ", gestureList.ToArray()), gesture);
                    Console.ForegroundColor = ConsoleColor.White;
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
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\tWhat is your name?\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public bool ValidateGesture(string gesture)
        {
            bool result = gestureList.Contains(gesture.ToLower());
            return result;
        }


    }
}
