namespace MinesweeperGUI
{
    partial class HighScore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.yourScoreLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerListBox
            // 
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 15;
            this.playerListBox.Location = new System.Drawing.Point(27, 39);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(205, 124);
            this.playerListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOP 5 HIGH SCORES";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(27, 214);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox.TabIndex = 2;
            // 
            // yourScoreLabel
            // 
            this.yourScoreLabel.AutoSize = true;
            this.yourScoreLabel.Location = new System.Drawing.Point(58, 180);
            this.yourScoreLabel.Name = "yourScoreLabel";
            this.yourScoreLabel.Size = new System.Drawing.Size(69, 15);
            this.yourScoreLabel.TabIndex = 3;
            this.yourScoreLabel.Text = "Your Score: ";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(133, 180);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 15);
            this.scoreLabel.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(157, 214);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Me!";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(194, 9);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(0, 15);
            this.difficultyLabel.TabIndex = 6;
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(85, 255);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(75, 23);
            this.playAgainButton.TabIndex = 7;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 290);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.yourScoreLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerListBox);
            this.Name = "HighScore";
            this.Text = "HighScore";
            this.Load += new System.EventHandler(this.HighScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label yourScoreLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Button playAgainButton;
    }
}