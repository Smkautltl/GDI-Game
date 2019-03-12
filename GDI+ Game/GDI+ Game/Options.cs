using System;
using System.Windows.Forms;

namespace GDI__Game
{
    public partial class Options : Form
    {
        public int _Difficulty = 2;
        public bool BoundsEnabled = false;

        public Options()
        {
            InitializeComponent();
        }
        private void Options_Load(object sender, EventArgs e)
        {
            Hide();
            ShowInTaskbar = false;
        }

        public void ShowForm()
        {
            Show();
            ShowInTaskbar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Hide();
        }

        private void EasyRadio_btn_CheckedChanged(object sender, EventArgs e)
        {
            DifficultyCheck();
        }
        private void MedRadio_btn_CheckedChanged(object sender, EventArgs e)
        {
            DifficultyCheck();
        }
        private void HardRadio_btn_CheckedChanged(object sender, EventArgs e)
        {
            DifficultyCheck();
        }
        private void ExtremeRadio_btn_CheckedChanged(object sender, EventArgs e)
        {
            DifficultyCheck();
        }

        public void DifficultyCheck()
        {
            if (EasyRadio_btn.Checked)
            {
                _Difficulty = 1;
            }
            else if (MedRadio_btn.Checked)
            {
                _Difficulty = 2;
            }
            else if (HardRadio_btn.Checked)
            {
                _Difficulty = 3;
            }
            else if (ExtremeRadio_btn.Checked)
            {
                _Difficulty = 4;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                BoundsEnabled = true;
            }
            else
            {
                BoundsEnabled = false;
            }
        }

        private void ChangeLog_Click(object sender, EventArgs e)
        {
            ChangeLog Log = new ChangeLog();
            Log.Show();
            Hide();
        }
    }
}
