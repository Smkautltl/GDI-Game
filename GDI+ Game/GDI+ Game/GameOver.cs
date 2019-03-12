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
    public partial class GameOver : Form
    {
        //Graphics                                                              //
        Bitmap _backBuffer;                                                     //
        Graphics _backBufferGr;                                                 //
        public static Graphics _gr;                                             //       
        private int _resWidth;                                                  //
        private int _resHeight;
        public int rank;

        private bool isRunning;
        Bitmap Gameover = new Bitmap(Properties.Resources.GameOver);
        private int score;
        private int BossedKilled;
        private int EnemiesKilled;

        public GameOver(int Score, int bossKilled, int EnemyKilled)
        {
            score = Score;
            BossedKilled = bossKilled;
            EnemiesKilled = EnemyKilled;

            InitializeComponent();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            _resWidth = 800;
            _resHeight = 1000;

            Show();
            Focus();
             
            isRunning = true;

            _gr = CreateGraphics();
            _backBuffer = new Bitmap(_resWidth, _resHeight);
            Gameover.MakeTransparent(Color.Fuchsia);

            Main.HighscoreForm.Difficult = Main.OptionsForm._Difficulty;

            for (int i = 0; i < 10; i++)
            {
                if (score >= Main.HighscoreForm.scores[i].score)
                {
                    rank = i;

                    Main.HighscoreForm.scores.Insert(i, new Score(score, EnemiesKilled, BossedKilled));

                    Inputbox input = new Inputbox(1);
                    input.Show();
                    input.Focus();
                    break;
                }
            }

            GameLoop();
        }

        void GameLoop()
        {
            

            do
            {
                Application.DoEvents();

                DrawGame();

            } while (isRunning);
        }

        void DrawGame()
        {
            _gr.DrawImage(Gameover, new Point(0,-100));
            _gr.DrawString("Score:" + score,new Font("Times New Roman", 36.0f),Brushes.White,200,350);
            _gr.DrawString("Enemies Killed:" + EnemiesKilled,new Font("Times New Roman", 36.0f),Brushes.White,200,450);
            _gr.DrawString("Bosses Killed:" + BossedKilled,new Font("Times New Roman", 36.0f),Brushes.White,200,550);

            _gr = Graphics.FromImage(_backBuffer);
            try
            {
                _backBufferGr = CreateGraphics();
                _backBufferGr.DrawImage(_backBuffer, 0, 0, _resWidth, _resHeight);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR\n" + ex.ToString());
            }

            _gr.Clear(Color.Black);
        }

        public void SortHighscores()
        {      
            Main.HighscoreForm.WriteTable();
        }

        private void ReplayButton_Click(object sender, EventArgs e)
        {
            Main.StartGame();
        }
        private void HighscoreButton_Click(object sender, EventArgs e)
        {
            Main.HighscoreForm.LoadTable();
            Main.ShowHighscore();
        }
        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Main.ShowMainMenu();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Inputbox input = new Inputbox(2);
            input.Show();
        }
    }
}
