using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Score
    {
        public Score()
        {

        }

        public string FindWinner(string player1, string player2)
        {
            string result = "";
            if (player1 == player2)
            {
                result = "tie";
            } else 
            {
                switch ((player1 + player2).ToLower())
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
                        break;
                    default:
                        result = "player2";
                        break;
                }
            }
            return result;
        }
        
    }
}
