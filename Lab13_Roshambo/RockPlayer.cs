using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_Roshambo
{
    class RockPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
