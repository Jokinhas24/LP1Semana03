using System;

namespace RoPaSci
{
    public class Program
    {
        private static void Main(string[] args)
        {
            GameItem player1 = Enum.Parse<GameItem>(args[0]);
            GameItem player2 = Enum.Parse<GameItem>(args[1]);

            int result = RockPaperScissors(player1, player2);
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

        private static int RockPaperScissors(GameItem player1, GameItem player2)
        {
            int GameResult = 0;

            if (player1 == player2)
            {
                GameResult = (int)GameStatus.Draw; // Draw
            }
            if (((player1 == GameItem.Rock) && (player2 == GameItem.Scissors)) ||
                ((player1 == GameItem.Scissors) && (player2 == GameItem.Paper)) ||
                ((player1 == GameItem.Paper) && (player2 == GameItem.Rock)))
            {
                GameResult = (int)GameStatus.Player1Wins; // Player 1 wins
            }
            else
            {
                GameResult = (int)GameStatus.Player2Wins; // Player 2 wins
            }
            return GameResult;
        }
    }
}
