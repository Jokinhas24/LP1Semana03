using System;
using System.Text;

namespace RPS
{
    class Program
    {
        private static void Main(string[] args)
        {
            int result = RockPaperScissors(args[0], args[1]);
            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(string player1, string player2)
        {
            int GameResult = 0;

            player1 = player1.ToLower();
            player2 = player2.ToLower();

            Console.WriteLine(player1);
            Console.WriteLine(player2);

            if (player1 == player2)
            {
                GameResult = 0; // Draw
            }
            else
            {
                if (((player1 == "rock") && (player2 == "scissors")) ||
                    ((player1 == "scissors") && (player2 == "paper")) ||
                    ((player1 == "paper") && (player2 == "rock")))
                {
                    GameResult = 1; // Player 1 wins
                }
                else
                {
                    GameResult = 2; // Player 2 wins
                }
            }
            return GameResult;
        }
    }
}
