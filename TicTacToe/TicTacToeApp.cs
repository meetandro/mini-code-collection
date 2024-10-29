namespace TicTacToe;

public partial class TicTacToeApp : Form
{
    public TicTacToeApp()
    {
        InitializeComponent();
    }

    private void InputButton_Click(object sender, EventArgs e)
    {
        var button = (Button)sender;

        if (!TicTacToeGame.GameEnded && string.IsNullOrEmpty(button.Text))
        {
            button.Text += TicTacToeGame.FillButton(button.Name[^1] - '0' - 1);
            ResultLabel.Text = TicTacToeGame.CheckProgress();
        }
    }

    private void RestartButton_Click(object sender, EventArgs e)
    {
        for (int i = 1; i < 10; i++)
        {
            Controls["InputButton" + i].Text = string.Empty;
        }
        ResultLabel.Text = "Player X Turn";
        TicTacToeGame.RestartGame();
    }
}