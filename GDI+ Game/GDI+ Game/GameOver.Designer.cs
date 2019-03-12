namespace GDI__Game
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.HighscoreButton = new System.Windows.Forms.Button();
            this.ReplayButton = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuButton.ForeColor = System.Drawing.Color.White;
            this.MainMenuButton.Location = new System.Drawing.Point(206, 850);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(361, 99);
            this.MainMenuButton.TabIndex = 0;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // HighscoreButton
            // 
            this.HighscoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HighscoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighscoreButton.ForeColor = System.Drawing.Color.White;
            this.HighscoreButton.Location = new System.Drawing.Point(206, 745);
            this.HighscoreButton.Name = "HighscoreButton";
            this.HighscoreButton.Size = new System.Drawing.Size(361, 99);
            this.HighscoreButton.TabIndex = 1;
            this.HighscoreButton.Text = "Highscore Table";
            this.HighscoreButton.UseVisualStyleBackColor = true;
            this.HighscoreButton.Click += new System.EventHandler(this.HighscoreButton_Click);
            // 
            // ReplayButton
            // 
            this.ReplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayButton.ForeColor = System.Drawing.Color.White;
            this.ReplayButton.Location = new System.Drawing.Point(206, 640);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(361, 99);
            this.ReplayButton.TabIndex = 2;
            this.ReplayButton.Text = "Replay";
            this.ReplayButton.UseVisualStyleBackColor = true;
            this.ReplayButton.Click += new System.EventHandler(this.ReplayButton_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.Red;
            this.Close.Location = new System.Drawing.Point(748, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(24, 23);
            this.Close.TabIndex = 3;
            this.Close.TabStop = false;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 961);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ReplayButton);
            this.Controls.Add(this.HighscoreButton);
            this.Controls.Add(this.MainMenuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOver";
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Button HighscoreButton;
        private System.Windows.Forms.Button ReplayButton;
        private System.Windows.Forms.Button Close;
    }
}