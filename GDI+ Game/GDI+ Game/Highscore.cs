using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI__Game
{
    public partial class Highscore : Form
    {
        Encryption EncryptDecrypt = new Encryption();
        private string[] Table = new string[10];
        public int Difficult;
        private StreamReader sr;
        private StreamWriter sw;
        public List<Score> scores = new List<Score>();      

        public Highscore(int Difficulty)
        {
            InitializeComponent();
            Difficult = Difficulty;

            for (int i = 0; i < 11; i++)
            {
                scores.Add(new Score());
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Hide();
        }
        private void Highscore_Load(object sender, EventArgs e)
        {
            Show();
            Focus();

            
            LoadTable();
        }

        public void LoadTable()
        { 
            Application.DoEvents();

            progressBar.Value = 0;
            switch (Difficult)
            {
                case 1:
                    sr = new StreamReader(Application.StartupPath + @"\Highscore\Easy.Highscore");
                    break;

                case 2:
                    sr = new StreamReader(Application.StartupPath + @"\Highscore\Medium.Highscore");
                    break;

                case 3:
                    sr = new StreamReader(Application.StartupPath + @"\Highscore\Hard.Highscore");
                    break;

                case 4:
                    sr = new StreamReader(Application.StartupPath + @"\Highscore\Extreme.Highscore");
                    break;
            }

            ProgressBarlbl.Text = "Loading Table";
            ProgressBarlbl.Show();
            for (int i = 0; i < 10; i++)
            {
                Application.DoEvents();
                Table[i] = sr.ReadLine();
                progressBar.Value += 10;
                //System.Threading.Thread.Sleep(50);
            }

            progressBar.Value = 0;

            ProgressBarlbl.Text = "Decrypting Table";
            ProgressBarlbl.Show();
            for (int i = 0; i < 10; i++)
            {
                string Temp = "";

                for (int j = 0; j < Table[i].Length; j++)
                {
                    Temp += EncryptDecrypt.Decrypt(Convert.ToString(Table[i][j]));
                    Application.DoEvents();
                }
                progressBar.Value += 10;
                //System.Threading.Thread.Sleep(50);
                Table[i] = Temp;
            }

            progressBar.Value = 0;
            ProgressBarlbl.Text = "Writing to RAM";
            ProgressBarlbl.Show();
            for (int i = 0; i < 10; i++)
            {
                string Temp = "";
                int Num = 0;
                for (int j = 0; j < Table[i].Length; j++)
                {
                    Application.DoEvents();
                    if (Convert.ToString(Table[i][j]) == ",")
                    {
                        switch (Num)
                        {
                            case 0:
                                scores[i].Name = Temp;
                                Temp = "";
                                break;

                            case 1:
                                try
                                {
                                    scores[i].score = Convert.ToInt32(Temp);
                                    Temp = "";
                                }
                                catch (Exception e)
                                {
                                    scores[i].score = 0;
                                }                               
                                break;

                            case 2:
                                try
                                {
                                    scores[i].EnemiesKilled = Convert.ToInt32(Temp);
                                    Temp = "";
                                }
                                catch (Exception e)
                                {
                                    scores[i].EnemiesKilled = 0;
                                }
                                break;

                            case 3:
                                try
                                {
                                    scores[i].BossesKilled = Convert.ToInt32(Temp);
                                    Temp = "";
                                }
                                catch (Exception e)
                                {
                                    scores[i].BossesKilled = 0;
                                }
                                break;
                        }
                        Num++;
                    }
                    else
                    {
                        Temp += Convert.ToString(Table[i][j]);
                    }
                }
                progressBar.Value += 10;
                //System.Threading.Thread.Sleep(50);
            }

            progressBar.Value = 0;
            ProgressBarlbl.Text = "Writing to Labels";
            ProgressBarlbl.Show();

            for (int i = 0; i < 10; i++)
            {
                Application.DoEvents();
                switch (i)
                {
                    case 1:
                        Name2lbl.Text = scores[i].Name;
                        Score2lbl.Text = Convert.ToString(scores[i].score);
                        EnemyKilled2lbl.Text = Convert.ToString(scores[i].EnemiesKilled);
                        BossesKilled2lbl.Text = Convert.ToString(scores[i].BossesKilled);
                        break;

                    case 2:
                        Name3lbl.Text = scores[i].Name;
                        Score3lbl.Text = Convert.ToString(scores[i].score);
                        EnemyKilled3lbl.Text = Convert.ToString(scores[i].EnemiesKilled);
                        BossesKilled3lbl.Text = Convert.ToString(scores[i].BossesKilled);
                        break;

                    case 3:
                        Name4lbl.Text = scores[i].Name;
                        Score4lbl.Text = Convert.ToString(scores[i].score);
                        EnemyKilled4lbl.Text = Convert.ToString(scores[i].EnemiesKilled);
                        BossesKilled4lbl.Text = Convert.ToString(scores[i].BossesKilled);
                        break;

                    case 4:
                        Name5lbl.Text = scores[i].Name;
                        Score5lbl.Text = Convert.ToString(scores[i].score);
                        EnemyKilled5lbl.Text = Convert.ToString(scores[i].EnemiesKilled);
                        BossesKille51lbl.Text = Convert.ToString(scores[i].BossesKilled);
                        break;

                    case 5:
                        Name6lbl.Text = scores[i].Name;
                        Score6lbl.Text = Convert.ToString(scores[i].score);
                        EnemyKilled6lbl.Text = Convert.ToString(scores[i].EnemiesKilled);
                        BossesKilled6lbl.Text = Convert.ToString(scores[i].BossesKilled);
                        break;

                    case 6:
                        Name7lbl.Text = scores[i].Name;
                        Score7lbl.Text = Convert.ToString(scores[i].score);
                        EnemyKilled7lbl.Text = Convert.ToString(scores[i].EnemiesKilled);
                        BossesKilled7lbl.Text = Convert.ToString(scores[i].BossesKilled);
                        break;

                    case 7:
                        Name8lbl.Text = scores[i].Name;
                        Score8lbl.Text = Convert.ToString(scores[i].score);
                        EnemyKilled8lbl.Text = Convert.ToString(scores[i].EnemiesKilled);
                        BossesKilled8lbl.Text = Convert.ToString(scores[i].BossesKilled);
                        break;

                    case 8:
                        Name9lbl.Text = scores[i].Name;
                        Score9lbl.Text = Convert.ToString(scores[i].score);
                        EnemyKilled9lbl.Text = Convert.ToString(scores[i].EnemiesKilled);
                        BossesKilled9lbl.Text = Convert.ToString(scores[i].BossesKilled);
                        break;

                    case 9:
                        Name10lbl.Text = scores[i].Name;
                        Score10lbl.Text = Convert.ToString(scores[i].score);
                        EnemyKilled10lbl.Text = Convert.ToString(scores[i].EnemiesKilled);
                        BossesKilled10lbl.Text = Convert.ToString(scores[i].BossesKilled);
                        break;

                    case 0:
                        Name1lbl.Text = scores[i].Name;
                        Score1lbl.Text = Convert.ToString(scores[i].score);
                        EnemyKilled1lbl.Text = Convert.ToString(scores[i].EnemiesKilled);
                        BossesKilled1lbl.Text = Convert.ToString(scores[i].BossesKilled);
                        break;

                }

                progressBar.Value += 10;
                //System.Threading.Thread.Sleep(50);
            }

            ProgressBarlbl.Hide();
            progressBar.Hide();

            Name1lbl.Show();
            Name2lbl.Show();
            Name3lbl.Show();
            Name4lbl.Show();
            Name5lbl.Show();
            Name6lbl.Show();
            Name7lbl.Show();
            Name8lbl.Show();
            Name9lbl.Show();
            Name10lbl.Show();

            Score1lbl.Show();
            Score2lbl.Show();
            Score3lbl.Show();
            Score4lbl.Show();
            Score5lbl.Show();
            Score6lbl.Show();
            Score7lbl.Show();
            Score8lbl.Show();
            Score9lbl.Show();
            Score10lbl.Show();

            EnemyKilled1lbl.Show();
            EnemyKilled2lbl.Show();
            EnemyKilled3lbl.Show();
            EnemyKilled4lbl.Show();
            EnemyKilled5lbl.Show();
            EnemyKilled6lbl.Show();
            EnemyKilled7lbl.Show();
            EnemyKilled8lbl.Show();
            EnemyKilled9lbl.Show();
            EnemyKilled10lbl.Show();

            BossesKilled1lbl.Show();
            BossesKilled2lbl.Show();
            BossesKilled3lbl.Show();
            BossesKilled4lbl.Show();
            BossesKille51lbl.Show();
            BossesKilled6lbl.Show();
            BossesKilled7lbl.Show();
            BossesKilled8lbl.Show();
            BossesKilled9lbl.Show();
            BossesKilled10lbl.Show();

            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label16.Show();
            label21.Show();
            label26.Show();
            label31.Show();
            label36.Show();
            label41.Show();
            label46.Show();
            label51.Show();
            label56.Show();
            label57.Show();           

            Easybtn.Show();
            Mediumbtn.Show();
            Hardbtn.Show();
            Extremebtn.Show();

            sr.Close();
        }

        public void WriteTable()
        {
            switch (Difficult)
            {
                case 1:
                    sw = new StreamWriter(Application.StartupPath + @"\Highscore\Easy.Highscore");
                    break;

                case 2:
                    sw = new StreamWriter(Application.StartupPath + @"\Highscore\Medium.Highscore");
                    break;

                case 3:
                    sw = new StreamWriter(Application.StartupPath + @"\Highscore\Hard.Highscore");
                    break;

                case 4:
                    sw = new StreamWriter(Application.StartupPath + @"\Highscore\Extreme.Highscore");
                    break;
            }

            for (int i = 0; i < 10; i++)
            {
                string Temp = "";
                Temp += scores[i].Name;
                Temp += ",";
                Temp += scores[i].score;
                Temp += ",";
                Temp += scores[i].EnemiesKilled;
                Temp += ",";
                Temp += scores[i].BossesKilled;
                
                
                string Temp2 = "";

                for (int j = 0; j < Temp.Length; j++)
                {
                    Temp2 += EncryptDecrypt.Encrypt(Convert.ToString(Temp[j]));
                }
                
                sw.WriteLine(Temp2);
            }

            sw.Close();
        }

        private void Easybtn_Click(object sender, EventArgs e)
        {
            ProgressBarlbl.Show();
            progressBar.Show();

            Easybtn.Hide();
            Mediumbtn.Hide();
            Hardbtn.Hide();
            Extremebtn.Hide();

            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label16.Hide();
            label21.Hide();
            label26.Hide();
            label31.Hide();
            label36.Hide();
            label41.Hide();
            label46.Hide();
            label51.Hide();
            label56.Hide();
            label57.Hide();

            Name1lbl.Hide();
            Name2lbl.Hide();
            Name3lbl.Hide();
            Name4lbl.Hide();
            Name5lbl.Hide();
            Name6lbl.Hide();
            Name7lbl.Hide();
            Name8lbl.Hide();
            Name9lbl.Hide();
            Name10lbl.Hide();

            Score1lbl.Hide();
            Score2lbl.Hide();
            Score3lbl.Hide();
            Score4lbl.Hide();
            Score5lbl.Hide();
            Score6lbl.Hide();
            Score7lbl.Hide();
            Score8lbl.Hide();
            Score9lbl.Hide();
            Score10lbl.Hide();

            EnemyKilled1lbl.Hide();
            EnemyKilled2lbl.Hide();
            EnemyKilled3lbl.Hide();
            EnemyKilled4lbl.Hide();
            EnemyKilled5lbl.Hide();
            EnemyKilled6lbl.Hide();
            EnemyKilled7lbl.Hide();
            EnemyKilled8lbl.Hide();
            EnemyKilled9lbl.Hide();
            EnemyKilled10lbl.Hide();

            BossesKilled1lbl.Hide();
            BossesKilled2lbl.Hide();
            BossesKilled3lbl.Hide();
            BossesKilled4lbl.Hide();
            BossesKille51lbl.Hide();
            BossesKilled6lbl.Hide();
            BossesKilled7lbl.Hide();
            BossesKilled8lbl.Hide();
            BossesKilled9lbl.Hide();
            BossesKilled10lbl.Hide();

            Difficult = 1;
            LoadTable();
        }
        private void Mediumbtn_Click(object sender, EventArgs e)
        {
            ProgressBarlbl.Show();
            progressBar.Show();

            Easybtn.Hide();
            Mediumbtn.Hide();
            Hardbtn.Hide();
            Extremebtn.Hide();

            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label16.Hide();
            label21.Hide();
            label26.Hide();
            label31.Hide();
            label36.Hide();
            label41.Hide();
            label46.Hide();
            label51.Hide();
            label56.Hide();
            label57.Hide();

            Name1lbl.Hide();
            Name2lbl.Hide();
            Name3lbl.Hide();
            Name4lbl.Hide();
            Name5lbl.Hide();
            Name6lbl.Hide();
            Name7lbl.Hide();
            Name8lbl.Hide();
            Name9lbl.Hide();
            Name10lbl.Hide();

            Score1lbl.Hide();
            Score2lbl.Hide();
            Score3lbl.Hide();
            Score4lbl.Hide();
            Score5lbl.Hide();
            Score6lbl.Hide();
            Score7lbl.Hide();
            Score8lbl.Hide();
            Score9lbl.Hide();
            Score10lbl.Hide();

            EnemyKilled1lbl.Hide();
            EnemyKilled2lbl.Hide();
            EnemyKilled3lbl.Hide();
            EnemyKilled4lbl.Hide();
            EnemyKilled5lbl.Hide();
            EnemyKilled6lbl.Hide();
            EnemyKilled7lbl.Hide();
            EnemyKilled8lbl.Hide();
            EnemyKilled9lbl.Hide();
            EnemyKilled10lbl.Hide();

            BossesKilled1lbl.Hide();
            BossesKilled2lbl.Hide();
            BossesKilled3lbl.Hide();
            BossesKilled4lbl.Hide();
            BossesKille51lbl.Hide();
            BossesKilled6lbl.Hide();
            BossesKilled7lbl.Hide();
            BossesKilled8lbl.Hide();
            BossesKilled9lbl.Hide();
            BossesKilled10lbl.Hide();

            Difficult = 2;
            LoadTable();
        }
        private void Hardbtn_Click(object sender, EventArgs e)
        {
            ProgressBarlbl.Show();
            progressBar.Show();

            Easybtn.Hide();
            Mediumbtn.Hide();
            Hardbtn.Hide();
            Extremebtn.Hide();

            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label16.Hide();
            label21.Hide();
            label26.Hide();
            label31.Hide();
            label36.Hide();
            label41.Hide();
            label46.Hide();
            label51.Hide();
            label56.Hide();
            label57.Hide();

            Name1lbl.Hide();
            Name2lbl.Hide();
            Name3lbl.Hide();
            Name4lbl.Hide();
            Name5lbl.Hide();
            Name6lbl.Hide();
            Name7lbl.Hide();
            Name8lbl.Hide();
            Name9lbl.Hide();
            Name10lbl.Hide();

            Score1lbl.Hide();
            Score2lbl.Hide();
            Score3lbl.Hide();
            Score4lbl.Hide();
            Score5lbl.Hide();
            Score6lbl.Hide();
            Score7lbl.Hide();
            Score8lbl.Hide();
            Score9lbl.Hide();
            Score10lbl.Hide();

            EnemyKilled1lbl.Hide();
            EnemyKilled2lbl.Hide();
            EnemyKilled3lbl.Hide();
            EnemyKilled4lbl.Hide();
            EnemyKilled5lbl.Hide();
            EnemyKilled6lbl.Hide();
            EnemyKilled7lbl.Hide();
            EnemyKilled8lbl.Hide();
            EnemyKilled9lbl.Hide();
            EnemyKilled10lbl.Hide();

            BossesKilled1lbl.Hide();
            BossesKilled2lbl.Hide();
            BossesKilled3lbl.Hide();
            BossesKilled4lbl.Hide();
            BossesKille51lbl.Hide();
            BossesKilled6lbl.Hide();
            BossesKilled7lbl.Hide();
            BossesKilled8lbl.Hide();
            BossesKilled9lbl.Hide();
            BossesKilled10lbl.Hide();

            Difficult = 3;
            LoadTable();
        }
        private void Extremebtn_Click(object sender, EventArgs e)
        {
            ProgressBarlbl.Show();
            progressBar.Show();

            Easybtn.Hide();
            Mediumbtn.Hide();
            Hardbtn.Hide();
            Extremebtn.Hide();

            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label16.Hide();
            label21.Hide();
            label26.Hide();
            label31.Hide();
            label36.Hide();
            label41.Hide();
            label46.Hide();
            label51.Hide();
            label56.Hide();
            label57.Hide();

            Name1lbl.Hide();
            Name2lbl.Hide();
            Name3lbl.Hide();
            Name4lbl.Hide();
            Name5lbl.Hide();
            Name6lbl.Hide();
            Name7lbl.Hide();
            Name8lbl.Hide();
            Name9lbl.Hide();
            Name10lbl.Hide();

            Score1lbl.Hide();
            Score2lbl.Hide();
            Score3lbl.Hide();
            Score4lbl.Hide();
            Score5lbl.Hide();
            Score6lbl.Hide();
            Score7lbl.Hide();
            Score8lbl.Hide();
            Score9lbl.Hide();
            Score10lbl.Hide();

            EnemyKilled1lbl.Hide();
            EnemyKilled2lbl.Hide();
            EnemyKilled3lbl.Hide();
            EnemyKilled4lbl.Hide();
            EnemyKilled5lbl.Hide();
            EnemyKilled6lbl.Hide();
            EnemyKilled7lbl.Hide();
            EnemyKilled8lbl.Hide();
            EnemyKilled9lbl.Hide();
            EnemyKilled10lbl.Hide();

            BossesKilled1lbl.Hide();
            BossesKilled2lbl.Hide();
            BossesKilled3lbl.Hide();
            BossesKilled4lbl.Hide();
            BossesKille51lbl.Hide();
            BossesKilled6lbl.Hide();
            BossesKilled7lbl.Hide();
            BossesKilled8lbl.Hide();
            BossesKilled9lbl.Hide();
            BossesKilled10lbl.Hide();

            Difficult = 4;
            LoadTable();
        }
    }
}
