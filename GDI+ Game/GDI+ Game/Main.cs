using System;
using System.IO;
using System.Windows.Forms;

namespace GDI__Game
{
    public partial class Main : Form
    {
        public static Main MainInstance;
        static Menu MainMenu;
        static Game GameForm;
        public static Options OptionsForm;
        public static GameOver GameoverForm;
        public static Highscore HighscoreForm;
        private Encryption Encrypt = new Encryption();

        public Main()
        {
            //Everyone eveywhere in the app should know me as Main.MainInstance
            MainInstance = this;

            //Make sure I am kept hidden
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Visible = false;

            InitializeComponent();

            //Open a managed form - the one the user sees..
                     
            OptionsForm = new Options();
            OptionsForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            OptionsForm.ShowInTaskbar = false;

            HighscoreForm = new Highscore(OptionsForm._Difficulty);
            HighscoreForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            HighscoreForm.ShowInTaskbar = false;
            HighscoreForm.LoadTable();

            MainMenu = new Menu();
            MainMenu.FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenu.Show();

        }

        public static void StartGame()
        {
            GameoverForm?.Dispose();
            MainMenu?.Dispose();

            GameForm = new Game();
            GameForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            GameForm.Show();
        }

        public void ShowOptions()
        {
            OptionsForm.Show();
            OptionsForm.ShowInTaskbar = true;
        }

        public static void ShowGameOver(int Score,int EnemiesKilled, int BossesKilled)
        {
            GameForm.Dispose();
            GameoverForm = new GameOver(Score, BossesKilled ,EnemiesKilled);
            GameoverForm.Show();
        }
        public static void ShowMainMenu()
        {
            GameForm.Dispose();
            MainMenu = new Menu();
            MainMenu.FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenu.Show();
        }
        public static void ShowHighscore()
        {         
            HighscoreForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
