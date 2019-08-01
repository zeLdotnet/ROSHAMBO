using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_Roshambo
{
    class RoshamboApp
    {
        public static void Run()
        {
            Player user = new UserPlayer();
            bool go = true;

            Console.WriteLine("Yo! Enter your name!");
            user.Name = Console.ReadLine();

            while (go)
            {
                Console.WriteLine("\nChoose an opponent!");
                Console.WriteLine("1. Wilbur");
                Console.Write("2. Rocky\t");

                Player userOpponent = PickPlayer();
                //Console.WriteLine(userOpponent.Name);

                Roshambo match = RockPaperScissors(userOpponent);
                //Console.WriteLine(match);

                Console.Write("\nChoose your weapon!\t");
                Console.Write("[ rock. paper. scissors ]\t");
                string userPick = Console.ReadLine();
                string print = RoshamboResults(userPick, match);

                Console.WriteLine('\n');
                Console.WriteLine(print);

                Console.WriteLine("\nenter [y] to play again. any other key to close.");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain == "y" || playAgain == "yes")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("\nThanks for playing!");
                    go = false;
                }
            }
        }

        public static Player PickPlayer()
        {
            string opponent = Console.ReadLine();

            if (opponent == "1")
            {
                Player rp = new RandomPlayer();
                rp.Name = "Wilbur";
                return rp;
            }
            else if (opponent == "2")
            {
                Player rock = new RockPlayer();
                rock.Name = "Rocky";
                return rock;
            }
            else
            {
                return new RandomPlayer();
            }
        }

        public static Roshambo RockPaperScissors(Player opponent)
        {
            if (opponent.Name == "Wilbur")
            {
                // opponent = new RandomPlayer();
                return opponent.GenerateRoshambo();
            }
            else if (opponent.Name == "Rocky")
            {
                //  opponent = new RockPlayer();
                return opponent.GenerateRoshambo();
            }
            else
            {
                return Roshambo.paper;
            }
        }

        public static string RoshamboResults(string userThrow, Roshambo opponentThrow)
        {
            if (userThrow == "rock" && opponentThrow == Roshambo.paper)
            {
                return $"{userThrow} vs. {opponentThrow}. \tYou lose...";
            }
            else if (userThrow == "rock" && opponentThrow == Roshambo.scissors)
            {
                return $"{userThrow} vs. {opponentThrow} \tYou win!";
            }
            else if (userThrow == "rock" && opponentThrow == Roshambo.rock)
            {
                return $"{userThrow} vs. {opponentThrow} \t-draw-";
            }
            else if (userThrow == "paper" && opponentThrow == Roshambo.scissors)
            {
                return $"{userThrow} vs. {opponentThrow}. \tYou lose...";
            }
            else if (userThrow == "paper" && opponentThrow == Roshambo.rock)
            {
                return $"{userThrow} vs. {opponentThrow}. \tYou win!";
            }
            else if (userThrow == "paper" && opponentThrow == Roshambo.paper)
            {
                return $"{userThrow} vs. {opponentThrow} \t-draw-";
            }
            else if (userThrow == "scissors" && opponentThrow == Roshambo.rock)
            {
                return $"{userThrow} vs. {opponentThrow}. \tYou lose...";
            }
            else if (userThrow == "scissors" && opponentThrow == Roshambo.paper)
            {
                return $"{userThrow} vs. {opponentThrow}. \tYou win!";
            }
            else
            {
                return $"{userThrow} vs. {opponentThrow} \t-draw-";
            }
        }
    }
}