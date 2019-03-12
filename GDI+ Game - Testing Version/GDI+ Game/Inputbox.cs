using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI__Game
{
    public partial class Inputbox : Form
    {
        private int Type;

        public Inputbox(int Message)
        {
            InitializeComponent();
            Type = Message;

            switch (Message)
            {
                case 1:
                    richTextBox1.Text = "Please enter your name as you have ranked in the highscore table";
                    richTextBox2.Show();
                    break;

                case 2:
                    richTextBox1.Text = "Are you sure that you want to quit?";
                    richTextBox2.Hide();
                    Submitbtn.Text = "Yes";
                    Cancelbtn.Text = "No";
                    Submitbtn.Location = new Point(150,50);
                    Cancelbtn.Location = new Point(70,50);
                    this.Size = new Size(250,120);
                    break;
            }

        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            switch (Type)
            {
                case 1:
                    Main.HighscoreForm.scores[Main.GameoverForm.rank].Name = richTextBox2.Text;
                    Main.GameoverForm.SortHighscores();
                    Dispose();
                    Close();
                    break;

                case 2:
                    Environment.Exit(1);
                    break;
            }         
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
