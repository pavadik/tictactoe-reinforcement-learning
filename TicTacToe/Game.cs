using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TicTacToe
{
    private char[] board;
    public char? CurrentWinner { get; private set; }

    public char[] Board { get { return board; } }

    public TicTacToe()
    {
        board = new char[9];
        for (int i = 0; i < board.Length; i++)
            board[i] = ' ';
    }

    public void Reset()
    {
        for (int i = 0; i < board.Length; i++)
        {
            board[i] = ' ';
        }
        CurrentWinner = null;
    }

    public void PrintBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("| " + board[i * 3] + " | " + board[i * 3 + 1] + " | " + board[i * 3 + 2] + " |");
        }
    }

    public List<int> AvailableMoves()
    {
        List<int> moves = new List<int>();
        for (int i = 0; i < board.Length; i++)
        {
            if (board[i] == ' ')
                moves.Add(i);
        }
        return moves;
    }

    public bool MakeMove(int square, char letter)
    {
        if (board[square] == ' ')
        {
            board[square] = letter;
            if (Winner(square, letter))
                CurrentWinner = letter;
            return true;
        }
        return false;
    }

    private bool Winner(int square, char letter)
    {
        int rowInd = square / 3;
        bool rowWin = true;
        for (int i = 0; i < 3; i++)
        {
            if (board[rowInd * 3 + i] != letter)
            {
                rowWin = false;
                break;
            }
        }
        if (rowWin) return true;

        int colInd = square % 3;
        bool colWin = true;
        for (int i = 0; i < 3; i++)
        {
            if (board[colInd + i * 3] != letter)
            {
                colWin = false;
                break;
            }
        }
        if (colWin) return true;

        if (square % 2 == 0)
        {
            bool diagonal1Win = true;
            for (int i = 0; i < 3; i++)
            {
                if (board[i * 4] != letter)
                {
                    diagonal1Win = false;
                    break;
                }
            }
            if (diagonal1Win) return true;

            bool diagonal2Win = true;
            for (int i = 0; i < 3; i++)
            {
                if (board[2 * (i + 1)] != letter)
                {
                    diagonal2Win = false;
                    break;
                }
            }
            if (diagonal2Win) return true;
        }

        return false;
    }
}
