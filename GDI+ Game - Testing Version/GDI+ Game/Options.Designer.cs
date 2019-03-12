namespace GDI__Game
{
    partial class Options
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Difficulty = new System.Windows.Forms.Label();
            this.ExtremeRadio_btn = new System.Windows.Forms.RadioButton();
            this.HardRadio_btn = new System.Windows.Forms.RadioButton();
            this.MedRadio_btn = new System.Windows.Forms.RadioButton();
            this.EasyRadio_btn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ChangeLog = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Difficulty);
            this.groupBox1.Controls.Add(this.ExtremeRadio_btn);
            this.groupBox1.Controls.Add(this.HardRadio_btn);
            this.groupBox1.Controls.Add(this.MedRadio_btn);
            this.groupBox1.Controls.Add(this.EasyRadio_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Difficulty
            // 
            this.Difficulty.AutoSize = true;
            this.Difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difficulty.ForeColor = System.Drawing.Color.White;
            this.Difficulty.Location = new System.Drawing.Point(6, 16);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(94, 25);
            this.Difficulty.TabIndex = 4;
            this.Difficulty.Text = "Difficulty";
            // 
            // ExtremeRadio_btn
            // 
            this.ExtremeRadio_btn.AutoSize = true;
            this.ExtremeRadio_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtremeRadio_btn.ForeColor = System.Drawing.Color.Red;
            this.ExtremeRadio_btn.Location = new System.Drawing.Point(11, 134);
            this.ExtremeRadio_btn.Name = "ExtremeRadio_btn";
            this.ExtremeRadio_btn.Size = new System.Drawing.Size(86, 24);
            this.ExtremeRadio_btn.TabIndex = 3;
            this.ExtremeRadio_btn.Text = "Extreme";
            this.ExtremeRadio_btn.UseVisualStyleBackColor = true;
            this.ExtremeRadio_btn.CheckedChanged += new System.EventHandler(this.ExtremeRadio_btn_CheckedChanged);
            // 
            // HardRadio_btn
            // 
            this.HardRadio_btn.AutoSize = true;
            this.HardRadio_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardRadio_btn.ForeColor = System.Drawing.Color.White;
            this.HardRadio_btn.Location = new System.Drawing.Point(11, 104);
            this.HardRadio_btn.Name = "HardRadio_btn";
            this.HardRadio_btn.Size = new System.Drawing.Size(62, 24);
            this.HardRadio_btn.TabIndex = 2;
            this.HardRadio_btn.Text = "Hard";
            this.HardRadio_btn.UseVisualStyleBackColor = true;
            this.HardRadio_btn.CheckedChanged += new System.EventHandler(this.HardRadio_btn_CheckedChanged);
            // 
            // MedRadio_btn
            // 
            this.MedRadio_btn.AutoSize = true;
            this.MedRadio_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedRadio_btn.ForeColor = System.Drawing.Color.White;
            this.MedRadio_btn.Location = new System.Drawing.Point(11, 74);
            this.MedRadio_btn.Name = "MedRadio_btn";
            this.MedRadio_btn.Size = new System.Drawing.Size(83, 24);
            this.MedRadio_btn.TabIndex = 1;
            this.MedRadio_btn.Text = "Medium";
            this.MedRadio_btn.UseVisualStyleBackColor = true;
            this.MedRadio_btn.CheckedChanged += new System.EventHandler(this.MedRadio_btn_CheckedChanged);
            // 
            // EasyRadio_btn
            // 
            this.EasyRadio_btn.AutoSize = true;
            this.EasyRadio_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyRadio_btn.ForeColor = System.Drawing.Color.White;
            this.EasyRadio_btn.Location = new System.Drawing.Point(11, 44);
            this.EasyRadio_btn.Name = "EasyRadio_btn";
            this.EasyRadio_btn.Size = new System.Drawing.Size(62, 24);
            this.EasyRadio_btn.TabIndex = 0;
            this.EasyRadio_btn.Text = "Easy";
            this.EasyRadio_btn.UseVisualStyleBackColor = true;
            this.EasyRadio_btn.CheckedChanged += new System.EventHandler(this.EasyRadio_btn_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(549, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(12, 219);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Enable Collision Bonds";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ChangeLog
            // 
            this.ChangeLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeLog.ForeColor = System.Drawing.Color.Gray;
            this.ChangeLog.Location = new System.Drawing.Point(520, 12);
            this.ChangeLog.Name = "ChangeLog";
            this.ChangeLog.Size = new System.Drawing.Size(23, 23);
            this.ChangeLog.TabIndex = 3;
            this.ChangeLog.Text = "C";
            this.ChangeLog.UseVisualStyleBackColor = true;
            this.ChangeLog.Click += new System.EventHandler(this.ChangeLog_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.ControlBox = false;
            this.Controls.Add(this.ChangeLog);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton EasyRadio_btn;
        private System.Windows.Forms.RadioButton HardRadio_btn;
        private System.Windows.Forms.RadioButton MedRadio_btn;
        private System.Windows.Forms.RadioButton ExtremeRadio_btn;
        private System.Windows.Forms.Label Difficulty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ChangeLog;
    }
}