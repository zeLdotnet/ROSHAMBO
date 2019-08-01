using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_Roshambo
{
    class UserPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            string userChoice = Console.ReadLine().ToLower();
            if(userChoice == "rock")
            {
                return Roshambo.rock;
            }
            else if(userChoice == "paper")
            {
                return Roshambo.paper;
            } 
            else if(userChoice == "scissors")
            {
                return Roshambo.scissors;
            }
            else
            {
                return 0;
            }
        }
    }
}
