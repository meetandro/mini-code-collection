namespace TicTacToe;

partial class TicTacToeApp
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        InputButton1 = new Button();
        InputButton2 = new Button();
        InputButton3 = new Button();
        InputButton4 = new Button();
        InputButton5 = new Button();
        InputButton6 = new Button();
        InputButton7 = new Button();
        InputButton8 = new Button();
        InputButton9 = new Button();
        RestartButton = new Button();
        ResultLabel = new Label();
        SuspendLayout();
        // 
        // InputButton1
        // 
        InputButton1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
        InputButton1.ForeColor = SystemColors.ControlDarkDark;
        InputButton1.Location = new Point(198, 100);
        InputButton1.Name = "InputButton1";
        InputButton1.Size = new Size(85, 67);
        InputButton1.TabIndex = 0;
        InputButton1.UseVisualStyleBackColor = true;
        InputButton1.Click += InputButton_Click;
        // 
        // InputButton2
        // 
        InputButton2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
        InputButton2.ForeColor = SystemColors.ControlDarkDark;
        InputButton2.Location = new Point(295, 100);
        InputButton2.Name = "InputButton2";
        InputButton2.Size = new Size(85, 67);
        InputButton2.TabIndex = 1;
        InputButton2.UseVisualStyleBackColor = true;
        InputButton2.Click += InputButton_Click;
        // 
        // InputButton3
        // 
        InputButton3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
        InputButton3.ForeColor = SystemColors.ControlDarkDark;
        InputButton3.Location = new Point(394, 100);
        InputButton3.Name = "InputButton3";
        InputButton3.Size = new Size(85, 67);
        InputButton3.TabIndex = 2;
        InputButton3.UseVisualStyleBackColor = true;
        InputButton3.Click += InputButton_Click;
        // 
        // InputButton4
        // 
        InputButton4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
        InputButton4.ForeColor = SystemColors.ControlDarkDark;
        InputButton4.Location = new Point(198, 186);
        InputButton4.Name = "InputButton4";
        InputButton4.Size = new Size(85, 67);
        InputButton4.TabIndex = 3;
        InputButton4.UseVisualStyleBackColor = true;
        InputButton4.Click += InputButton_Click;
        // 
        // InputButton5
        // 
        InputButton5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
        InputButton5.ForeColor = SystemColors.ControlDarkDark;
        InputButton5.Location = new Point(295, 186);
        InputButton5.Name = "InputButton5";
        InputButton5.Size = new Size(85, 67);
        InputButton5.TabIndex = 4;
        InputButton5.UseVisualStyleBackColor = true;
        InputButton5.Click += InputButton_Click;
        // 
        // InputButton6
        // 
        InputButton6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
        InputButton6.ForeColor = SystemColors.ControlDarkDark;
        InputButton6.Location = new Point(394, 186);
        InputButton6.Name = "InputButton6";
        InputButton6.Size = new Size(85, 67);
        InputButton6.TabIndex = 5;
        InputButton6.UseVisualStyleBackColor = true;
        InputButton6.Click += InputButton_Click;
        // 
        // InputButton7
        // 
        InputButton7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
        InputButton7.ForeColor = SystemColors.ControlDarkDark;
        InputButton7.Location = new Point(198, 266);
        InputButton7.Name = "InputButton7";
        InputButton7.Size = new Size(85, 67);
        InputButton7.TabIndex = 6;
        InputButton7.UseVisualStyleBackColor = true;
        InputButton7.Click += InputButton_Click;
        // 
        // InputButton8
        // 
        InputButton8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
        InputButton8.ForeColor = SystemColors.ControlDarkDark;
        InputButton8.Location = new Point(295, 266);
        InputButton8.Name = "InputButton8";
        InputButton8.Size = new Size(85, 67);
        InputButton8.TabIndex = 7;
        InputButton8.UseVisualStyleBackColor = true;
        InputButton8.Click += InputButton_Click;
        // 
        // InputButton9
        // 
        InputButton9.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
        InputButton9.ForeColor = SystemColors.ControlDarkDark;
        InputButton9.Location = new Point(394, 266);
        InputButton9.Name = "InputButton9";
        InputButton9.Size = new Size(85, 67);
        InputButton9.TabIndex = 8;
        InputButton9.UseVisualStyleBackColor = true;
        InputButton9.Click += InputButton_Click;
        // 
        // RestartButton
        // 
        RestartButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
        RestartButton.ForeColor = SystemColors.ControlDarkDark;
        RestartButton.Location = new Point(278, 352);
        RestartButton.Name = "RestartButton";
        RestartButton.Size = new Size(114, 36);
        RestartButton.TabIndex = 9;
        RestartButton.Text = "Restart";
        RestartButton.UseVisualStyleBackColor = true;
        RestartButton.Click += RestartButton_Click;
        // 
        // ResultLabel
        // 
        ResultLabel.AutoSize = true;
        ResultLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        ResultLabel.ForeColor = SystemColors.ControlDarkDark;
        ResultLabel.Location = new Point(233, 43);
        ResultLabel.Name = "ResultLabel";
        ResultLabel.Size = new Size(205, 41);
        ResultLabel.TabIndex = 11;
        ResultLabel.Text = "Player X Turn";
        // 
        // TicTacToeApp
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
        ClientSize = new Size(800, 450);
        Controls.Add(ResultLabel);
        Controls.Add(RestartButton);
        Controls.Add(InputButton9);
        Controls.Add(InputButton8);
        Controls.Add(InputButton7);
        Controls.Add(InputButton6);
        Controls.Add(InputButton5);
        Controls.Add(InputButton4);
        Controls.Add(InputButton3);
        Controls.Add(InputButton2);
        Controls.Add(InputButton1);
        Name = "TicTacToeApp";
        Text = "Tic Tac Toe";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button InputButton1;
    private Button InputButton2;
    private Button InputButton3;
    private Button InputButton4;
    private Button InputButton5;
    private Button InputButton6;
    private Button InputButton7;
    private Button InputButton8;
    private Button InputButton9;
    private Button RestartButton;
    private Label ResultLabel;
}