using System;
using System.IO;
using System.Threading;
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
        //Thread CreateOptionsThread = new Thread(new ThreadStart(CreateOptions));
        //static Thread CreateHighscoreThread = new Thread(new ThreadStart(CreateHighscore));
        //Thread CreateMainMenuThread = new Thread(new ThreadStart(CreateMainMenu));


        public Main()
        {
            //Everyone eveywhere in the app should know me as Main.MainInstance
            MainInstance = this;

            //Make sure I am kept hidden
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Visible = false;

            try
            {
               StreamReader sr = new StreamReader(Application.StartupPath + @"\Highscore\Easy.Highscore");
               sr = new StreamReader(Application.StartupPath + @"\Highscore\Medium.Highscore");
               sr = new StreamReader(Application.StartupPath + @"\Highscore\Hard.Highscore");
               sr = new StreamReader(Application.StartupPath + @"\Highscore\Extreme.Highscore");
               sr = null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Missing .Highscore file(s)!!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            InitializeComponent();
          
            CreateOptions();
            CreateHighscore();
            CreateMainMenu();

            //Open a managed form - the one the user sees..
                                                 
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
            GameForm?.Dispose();
            MainMenu = new Menu();
            MainMenu.FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenu.Show();
        }
        public static void ShowHighscore()
        {         
            HighscoreForm.Show();
        }

        void CreateOptions()
        {
            OptionsForm = new Options();
            OptionsForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            OptionsForm.ShowInTaskbar = false;
        }
        void CreateHighscore()
        {
            HighscoreForm = new Highscore(OptionsForm._Difficulty);
            HighscoreForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            HighscoreForm.ShowInTaskbar = false;
            HighscoreForm.LoadTable();
        }
        static void CreateMainMenu()
        {
            ShowMainMenu();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
