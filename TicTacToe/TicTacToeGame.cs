namespace TicTacToe;

public static class TicTacToeGame
{
    private static char[] board = { '-', '-', '-', '-', '-', '-', '-', '-', '-' };
    private static int turnCount;
    public static bool GameEnded { get; private set; }

    public static char FillButton(int currentBoardIndex)
    {
        turnCount++;

        if (turnCount % 2 == 0)
        {
            board[currentBoardIndex] = 'O';
            return 'O';
        }

        board[currentBoardIndex] = 'X';
        return 'X';
    }

    public static string CheckProgress()
    {
        if (turnCount == 9) return "Result : Draw";

        string[] solutions = { "012", "345", "678", "036", "147", "258", "048", "246" };
        char winner = '-';

        foreach (string solution in solutions)
        {
            int first = solution[0] - '0', second = solution[1] - '0', third = solution[2] - '0';

            if (board[first] == board[second] && board[second] == board[third] && board[first] != '-') winner = board[first];
        }

        if (winner != '-')
        {
            GameEnded = true;
            return $"Winner : {winner}";
        }

        return turnCount % 2 == 0 ? "Player X Turn" : "Player O Turn";
    }

    public static void RestartGame()
    {
        board = new char[] { '-', '-', '-', '-', '-', '-', '-', '-', '-' };
        turnCount = 0;
        GameEnded = false;
    }
}