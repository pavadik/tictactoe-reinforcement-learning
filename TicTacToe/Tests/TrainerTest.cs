using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

[TestClass]
public class TicTacToeTrainerTests
{
    [TestMethod]
    public void TestInitialization()
    {
        var trainer = new TicTacToeTrainer();
        Assert.IsNotNull(trainer);
        // Additional assertions can be made to check the state of the trainer
    }

    [TestMethod]
    public void TestSingleGamePlay()
    {
        var trainer = new TicTacToeTrainer();
        trainer.PlayGame(); // Assuming PlayGame is made public or internal for testing

        // Assert conditions that should be true after one game
        // For example, check if the game has a winner or it's a draw
    }

    [TestMethod]
    public void TestTrainingMultipleGames()
    {
        var trainer = new TicTacToeTrainer();
        int numGames = 10;
        trainer.TrainAgent(numGames);

        // Verify if the training process completed
        // This might include checking if the learning model was updated
    }

    [TestMethod]
    public void TestPolicySaving()
    {
        var trainer = new TicTacToeTrainer();
        trainer.TrainAgent(1);

        Assert.IsTrue(File.Exists("tictactoe_policy_x.pkl"));
        Assert.IsTrue(File.Exists("tictactoe_policy_o.pkl"));

        // Clean up test files
        File.Delete("tictactoe_policy_x.pkl");
        File.Delete("tictactoe_policy_o.pkl");
    }
}
