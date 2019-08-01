using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_Roshambo
{
    class RandomPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Random rand = new Random();
            int random = rand.Next(1, 4);

            if (random == 1)
            {
                return Roshambo.rock;
            }
            else if (random == 2)
            {
                return Roshambo.paper;
            }
            else  
            {
                return Roshambo.scissors;
            }
        }
    }
}
