using System;
using System.Collections.Generic;
using System.Text.Json;

public class TicTacToeAgent
{
    public char Letter { get; private set; }
    private Dictionary<string, int> stateValue;

    public TicTacToeAgent(char letter)
    {
        Letter = letter;
        stateValue = new Dictionary<string, int>();
    }

    public int GetMove(TicTacToe game)
    {
        List<int> availableMoves = game.AvailableMoves();
        if (availableMoves.Count == 0)
            return -1;  // Indicate no available moves
        Random rnd = new Random();
        return availableMoves[rnd.Next(availableMoves.Count)];
    }

    public void SavePolicy(string fileName)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(stateValue, options);
        File.WriteAllText(fileName, jsonString);
        Console.WriteLine($"Policy saved to {fileName}");
    }

    public void LoadPolicy(string fileName)
    {
        if (File.Exists(fileName))
        {
            string jsonString = File.ReadAllText(fileName);
            stateValue = JsonSerializer.Deserialize<Dictionary<string, int>>(jsonString);
            Console.WriteLine($"Policy loaded from {fileName}");
        }
        else
        {
            Console.WriteLine($"File {fileName} not found. Starting with an empty policy.");
            stateValue = new Dictionary<string, int>();
        }
    }

    public void Learn(int gameResult, TicTacToe game)
    {
        string state = string.Join("", game.Board);

        if (!stateValue.ContainsKey(state))
        {
            stateValue[state] = 0;
        }

        if (gameResult == 1)  // Win
        {
            stateValue[state] += 1;
        }
        else if (gameResult == -1)  // Loss
        {
            stateValue[state] -= 1;
        }
        // Do nothing for a draw
    }


}
