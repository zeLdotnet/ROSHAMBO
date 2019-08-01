using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_Roshambo
{
    abstract class Player
    {
        public string Name { get; set; }    
        public string RockPaperScissors { get; set; }

        abstract public Roshambo GenerateRoshambo(); 
    }
}
