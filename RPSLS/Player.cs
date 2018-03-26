using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Player : Person
    {
        bool gameWon;
        
        public Player()
        {
            
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
        public string GetName()
        {
            return name;
        }
        public bool GetGameWon()
        {
            return gameWon;
        }

    }
}
