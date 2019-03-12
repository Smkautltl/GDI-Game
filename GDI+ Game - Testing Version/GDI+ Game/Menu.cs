using System;
using System.Windows.Forms;

namespace GDI__Game
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.StartGame();
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Inputbox input = new Inputbox(2);
            input.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.MainInstance.ShowOptions();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main.ShowHighscore();
        }
    }
}
