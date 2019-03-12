namespace GDI__Game
{
    partial class Game
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
            this.Close = new System.Windows.Forms.Button();
            this._ControlBox = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.Close.TabIndex = 1;
            this.Close.TabStop = false;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // _ControlBox
            // 
            this._ControlBox.BackColor = System.Drawing.Color.Transparent;
            this._ControlBox.FlatAppearance.BorderSize = 0;
            this._ControlBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ControlBox.ForeColor = System.Drawing.Color.Transparent;
            this._ControlBox.Location = new System.Drawing.Point(-10, -10);
            this._ControlBox.Name = "_ControlBox";
            this._ControlBox.Size = new System.Drawing.Size(10, 10);
            this._ControlBox.TabIndex = 0;
            this._ControlBox.UseVisualStyleBackColor = false;
            this._ControlBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlBox_KeyDown);
            this._ControlBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ControlBox_KeyUp);
            // 
            // Continue
            // 
            this.Continue.Enabled = false;
            this.Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.Location = new System.Drawing.Point(198, 434);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(385, 113);
            this.Continue.TabIndex = 2;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Visible = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Options
            // 
            this.Options.Enabled = false;
            this.Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.Location = new System.Drawing.Point(198, 553);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(385, 113);
            this.Options.TabIndex = 3;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = true;
            this.Options.Visible = false;
            // 
            // Help
            // 
            this.Help.Enabled = false;
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.Location = new System.Drawing.Point(198, 672);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(385, 113);
            this.Help.TabIndex = 4;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Visible = false;
            // 
            // Quit
            // 
            this.Quit.Enabled = false;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.Location = new System.Drawing.Point(198, 791);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(385, 113);
            this.Quit.TabIndex = 5;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Visible = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 961);
            this.ControlBox = false;
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this._ControlBox);
            this.Controls.Add(this.Close);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button _ControlBox;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Quit;
    }
}