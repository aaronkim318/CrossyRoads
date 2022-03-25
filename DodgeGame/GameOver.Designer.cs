namespace DodgeGame
{
    partial class GameOver
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playAgainButton = new System.Windows.Forms.Button();
            this.endLine = new System.Windows.Forms.Label();
            this.endScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(213, 281);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(152, 66);
            this.playAgainButton.TabIndex = 0;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // endLine
            // 
            this.endLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.endLine.Location = new System.Drawing.Point(124, 180);
            this.endLine.Name = "endLine";
            this.endLine.Size = new System.Drawing.Size(250, 74);
            this.endLine.TabIndex = 1;
            this.endLine.Text = "Dang You Died. Your Score Was";
            // 
            // endScoreLabel
            // 
            this.endScoreLabel.AutoSize = true;
            this.endScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.endScoreLabel.Location = new System.Drawing.Point(380, 180);
            this.endScoreLabel.Name = "endScoreLabel";
            this.endScoreLabel.Size = new System.Drawing.Size(117, 20);
            this.endScoreLabel.TabIndex = 2;
            this.endScoreLabel.Text = "endScoreLabel";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.Controls.Add(this.endScoreLabel);
            this.Controls.Add(this.endLine);
            this.Controls.Add(this.playAgainButton);
            this.Name = "GameOver";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label endLine;
        private System.Windows.Forms.Label endScoreLabel;
    }
}
