using System;

public class TicTacToeTrainer
{
    private TicTacToeAgent playerX;
    private TicTacToeAgent playerO;
    private TicTacToe game;

    public TicTacToeTrainer()
    {
        playerX = new TicTacToeAgent('X');
        playerO = new TicTacToeAgent('O');
        game = new TicTacToe();
    }

    public void TrainAgent(int numGames)
    {
        for (int i = 0; i < numGames; i++)
        {
            PlayGame();
            game.Reset();  // Reset the game state for the next game
        }

        // Save the policy after training
        playerX.SavePolicy("tictactoe_policy_x.pkl");
        playerO.SavePolicy("tictactoe_policy_o.pkl");
    }

    public void PlayGame()
    {
        TicTacToeAgent currentPlayer = playerX;

        while (game.AvailableMoves().Count > 0)
        {
            int move = currentPlayer.GetMove(game);
            if (move == -1)
            {
                // Draw
                playerX.Learn(0, game);
                playerO.Learn(0, game);
                break;
            }

            game.MakeMove(move, currentPlayer.Letter);

            if (game.CurrentWinner != null)
            {
                // Update the learning model
                currentPlayer.Learn(1, game);  // Winner
                (currentPlayer == playerX ? playerO : playerX).Learn(-1, game);  // Loser
                game.PrintBoard();
                Console.WriteLine($"Player {currentPlayer.Letter} wins!");
                break;
            }

            // Switch turns
            currentPlayer = currentPlayer == playerX ? playerO : playerX;
        }
    }
}
