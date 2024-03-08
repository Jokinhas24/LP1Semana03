using System;
using System.Runtime.CompilerServices;
using System.Text;
using GameItem;
using GameStatus;

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
            
            if (player1 == player2)
            {
                GameResult = (int)Status.Draw; // Draw
            }
            else
            {
                if (((player1 == Items.rock.ToString()) 
                && (player2 == Items.scissors.ToString())) ||
                    ((player1 == Items.scissors.ToString()) 
                    && (player2 == Items.paper.ToString())) ||
                    ((player1 == Items.paper.ToString()) 
                    && (player2 == Items.rock.ToString())))
                {
                    GameResult = (int)Status.Player1Win; // Player 1 wins
                }
                else
                {
                    GameResult = (int)Status.Player2Win; // Player 2 wins
                }
            }
            return GameResult;
        }
    }
}
