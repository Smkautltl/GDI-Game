using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace GDI__Game
{
    public partial class Game : Form
    {
        //=====================VARIABLES========================================//
                                                                                //
        //Graphics                                                              //
        Bitmap _backBuffer;                                                     //
        Graphics _backBufferGr;                                                 //
        public static Graphics _gr;                                             //       
        private static int _resWidth;                                                  //
        private int _resHeight;                                                 //
                                                                                //
        //FPS                                                                   //
        int _tSec = DateTime.Now.Second;                                        //
        int _tTicks = 0;                                                        //
        int _tMax = 0;                                                          //
                                                                                //                                                                                //
        //Stars                                                                 //
        static List<StarVar> _Stars = new List<StarVar>();                             //
        private static int numStars = 300;                                             //
        private static int StarRefresh = 5;                                            //
                                                                                //
        //Key Detection
        public bool[] Movement = new bool[4];                                   //
        public static bool Fire;                                                       //
        public bool Pause = false;                                              //
                                                                                //
        //Player                                                                //
        public static Player Ship = new Player(Properties.Resources.Player_1);  //
        private static int BulletRefresh = 5;
        private bool SpecialFired = false;
        public static int score = 0;
        List<Heart> Hearts = new List<Heart>();
                                                                                //                                                                                //
        //Enemy                                                                 //
        public static List<Enemy> Enemies = new List<Enemy>();                  //
        private static int EnemyRefresh = 30;
        private static int EnemyRefreshHolder;
        private static int EnemyRefreshTick;
        public static int RarityThatCanUseBullets;
        private int ChangeEnemyRefresh = 2000;                                  //
        public static int EnemyKilled;

        //Boss
        public static Boss BossEnemy;
        private static int SpawnBoss = 10000;
        private int level = 1;
        public static bool BossSpawned = false;
        public static int BossKilled;

        //Threads
        Thread StarUpdateThread = new Thread(new ThreadStart(StarUpdate));
        Thread BulletUpdateThread = new Thread(new ThreadStart(BulletUpdate));
        Thread EnemyUpdateThread = new Thread(new ThreadStart(EnemyUpdate));
        Thread BossUpdateThread = new Thread(new ThreadStart(BossUpdate));

        //Other                                                                 //
        private bool _isRunning = true;  
        static Color PauseBack = Color.FromArgb(100,0,0,0);
        Brush PauseBrush = new SolidBrush(PauseBack);
        public static bool ShowBounds;
        private static bool isRunningThread = true;
        private static bool[] ThreadCompleted = new bool[4];

        //======================================================================//

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            _resWidth = 800;
            _resHeight = 1000;

            Show();
            Focus();

            switch (Main.OptionsForm._Difficulty)
            {
                case 1:
                    EnemyRefresh = 40;
                    RarityThatCanUseBullets = 6;
                    break;

                case 2:
                    EnemyRefresh = 30;
                    RarityThatCanUseBullets = 5;
                    break;

                case 3:
                    EnemyRefresh = 20;
                    RarityThatCanUseBullets = 4;
                    break;

                case 4:
                    EnemyRefresh = 10;
                    RarityThatCanUseBullets = 2;
                    break;

                default:
                    EnemyRefresh = 30;
                    RarityThatCanUseBullets = 5;
                    break;
            }

            ShowBounds = Main.OptionsForm.BoundsEnabled;

            _gr = CreateGraphics();
            _backBuffer = new Bitmap(_resWidth, _resHeight);
            Ship.PlayerPic.MakeTransparent(Color.Fuchsia);

            for (int i = 1; i <= Ship.PlayerLives; i++)
            {
                Hearts.Add(new Heart(i));
            }

            CreateStarField();

            //StarUpdateThread.Start();
            //BulletUpdateThread.Start();
            //EnemyUpdateThread.Start();
            //BossUpdateThread.Start();

            DrawLoop();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Inputbox input = new Inputbox(2);
            input.Show();
            Pause = true;
            Continue.Enabled = true;
            Continue.Visible = true;

            Options.Enabled = true;
            Options.Visible = true;

            Help.Enabled = true;
            Help.Visible = true;

            Quit.Enabled = true;
            Quit.Visible = true;

        }

        private void DrawLoop()
        {
            do
            {
                Application.DoEvents();

                if (Ship.PlayerLives <= 0)
                {
                    Main.ShowGameOver(score,EnemyKilled,BossKilled);
                    return;
                }

                if (Pause)
                {
                    FPS();

                    StarDraw();

                    BulletDraw();

                    EnemyDraw();
                    for (int i = Enemies.Count - 1; i > 0; i--)
                    {
                        for (int j = Enemies[i].BulletList.Count - 1; j > 0; j--)
                        {
                            Enemies[i].BulletList[j].Draw();
                        }
                    }

                    if (BossSpawned)
                    {
                        BossDraw();
                    }

                    PlayerDraw();
                    Ship.BulletDraw();
                    for (int i = Ship.BulletList.Count - 1; i > 0; i--)
                    {
                        Ship.BulletList[i].Draw();
                    }

                    _gr.FillRectangle(PauseBrush,0,0,800,1000);
                    GameDraw();
                }
                else
                {

                    //if (ThreadCompleted[0] && ThreadCompleted[1] && ThreadCompleted[2] && ThreadCompleted[3])
                   // {

                        FPS();

                        StarUpdate();
                        StarDraw();

                        BulletUpdate();
                        BulletDraw();

                        EnemyUpdate();
                        EnemyDraw();

                        if (BossSpawned)
                        {
                            BossUpdate();
                            BossDraw();
                        }

                        PlayerUpdate();
                        PlayerDraw();

                        GameDraw();

                        //ThreadCompleted[0] = false;
                        //ThreadCompleted[1] = false;
                        //ThreadCompleted[2] = false;
                        //ThreadCompleted[3] = false;
                    //}

                    //WriteToLogs();
                    System.Threading.Thread.Sleep(0);
                }

        } while (_isRunning);
        }

        void FPS()
        {
            if (_tSec == DateTime.Now.Second && _isRunning)
            {
                _tTicks = _tTicks + 1;
            }
            else
            {
                _tMax = _tTicks;
                _tTicks = 0;
                _tSec = DateTime.Now.Second;
            }
        }

        void CreateStarField()
        {
            _Stars.Clear();
            Random r = new Random();
            Point pt = new Point();
            for (int i = 0; i < numStars; i++)
            {
                pt.X = r.Next(0, _resWidth);
                pt.Y = r.Next(0, _resHeight);
                _Stars.Add(new StarVar(pt, r.Next(0, 6), r.Next(1, 4)));
            }
        }
        static void StarUpdate()
        {
            do
            {
                if (ThreadCompleted[0] == false)
                {
                    for (int i = 0; i < numStars; i++)
                    {
                        Point Temp = _Stars[i].Point();

                        if (Temp.Y < 1000)
                        {
                            if (StarRefresh == 0)
                            {
                                Temp.Y = Temp.Y + 1;
                                _Stars[i].SetPoint(Temp);
                            }
                        }
                        else
                        {
                            _Stars.Remove(_Stars[i]);
                            i--;

                            Random r = new Random();
                            Point pt = new Point();

                            pt.X = r.Next(0, _resWidth);
                            pt.Y = r.Next(0, 0);
                            _Stars.Add(new StarVar(pt, r.Next(0, 6), r.Next(1, 4)));
                        }
                    }

                    if (StarRefresh == 0)
                    {
                        StarRefresh = 10;
                    }
                    StarRefresh--;
                    ThreadCompleted[0] = true;
                }

            } while (isRunningThread);




            
        }
        void StarDraw()
        {
            for (int i = 0; i < numStars; i++)
            {
                //Console.WriteLine("{0}, {1}, {2}", i, _Stars[i].Point(), _Stars[i].Colour());

                if (_Stars[i].Colour() == 1)
                {
                    _gr.FillEllipse(Brushes.White,
                        new Rectangle(_Stars[1].Point(), new Size(_Stars[i].Size(), _Stars[i].Size())));
                }
                else if (_Stars[i].Colour() == 2)
                {
                    _gr.FillEllipse(Brushes.Red,
                        new Rectangle(_Stars[i].Point(), new Size(_Stars[i].Size(), _Stars[i].Size())));
                }
                else if (_Stars[i].Colour() == 3)
                {
                    _gr.FillEllipse(Brushes.Blue,
                        new Rectangle(_Stars[i].Point(), new Size(_Stars[i].Size(), _Stars[i].Size())));
                }
                else if (_Stars[i].Colour() == 4)
                {
                    _gr.FillEllipse(Brushes.OrangeRed,
                        new Rectangle(_Stars[i].Point(), new Size(_Stars[i].Size(), _Stars[i].Size())));
                }
                else if (_Stars[i].Colour() == 5)
                {
                    _gr.FillEllipse(Brushes.Yellow,
                        new Rectangle(_Stars[i].Point(), new Size(_Stars[i].Size(), _Stars[i].Size())));
                }
                else
                {
                    _gr.FillEllipse(Brushes.White,
                        new Rectangle(_Stars[i].Point(), new Size(_Stars[i].Size(), _Stars[i].Size())));
                }               
            }                       
        }

        static void BulletUpdate()
        {
            do
            {
                if (ThreadCompleted[1] == false)
                {
                    if (Fire)
                    {
                        switch (BulletRefresh)
                        {
                            case 0:
                                Ship.CreateBullet();
                                BulletRefresh = 5;
                                break;
                            case 1:
                                BulletRefresh--;
                                break;
                            case 2:
                                BulletRefresh--;
                                break;
                            case 3:
                                BulletRefresh--;
                                break;
                            case 4:
                                BulletRefresh--;
                                break;
                            case 5:
                                BulletRefresh--;
                                break;
                        }
                    }
                    Ship.UpdateBullets();

                    ThreadCompleted[1] = true;
                }


            } while (isRunningThread);


            
        }
        void BulletDraw()
        {
             Ship.BulletDraw();   
        }

        void PlayerUpdate()
            {
                if (Movement[0])
                {
                    if (Ship.PlayerLoc.Y <= 0)
                    {
                       
                    }
                    else
                    {
                    Point Temp = Ship.PlayerLoc;
                        Temp.Y -= 7;
                        Ship.PlayerLoc = Temp;
                        Ship.Bounds = new Rectangle(Temp, Ship.PlayerSize);
                    }                
                }

                if (Movement[1])
                {
                    if (Ship.PlayerLoc.Y >= (1000 - 32))
                    {
                        
                    }
                    else
                    {
                    Point Temp = Ship.PlayerLoc;
                        Temp.Y += 7;
                        Ship.PlayerLoc = Temp;
                        Ship.Bounds = new Rectangle(Temp, Ship.PlayerSize);
                    }                    
            }

                if (Movement[2])
                {
                    if (Ship.PlayerLoc.X <= -32)
                    {
                        
                    }
                    else
                    {
                        Point Temp = Ship.PlayerLoc;
                        Temp.X -= 7;
                        Ship.PlayerLoc = Temp;
                        Ship.Bounds = new Rectangle(Temp, Ship.PlayerSize);
                    }               
                }

                if (Movement[3])
                {
                    if (Ship.PlayerLoc.X >= (800-32))
                    {
                        
                    }
                    else
                    {
                    Point Temp = Ship.PlayerLoc;
                        Temp.X += 7;
                        Ship.PlayerLoc = Temp;
                        Ship.Bounds = new Rectangle(Temp, Ship.PlayerSize);
                    }                   
                }

                Ship.UpdateSpecialBullet();               
            }
        void PlayerDraw()
        {
            _gr.DrawImage(Ship.PlayerPic, Ship.PlayerLoc);

            if (ShowBounds)
            {
                _gr.DrawRectangle(Pens.Red, Ship.Bounds);
            }

            Ship.DrawSpecialBullet();
        }

        static void EnemyUpdate()
        {
            do
            {
                if (ThreadCompleted[2] == false)
                {

                    if (!BossSpawned)
                    {
                        if (EnemyRefreshTick <= 0)
                        {
                            Enemies.Add(new Enemy(RarityThatCanUseBullets));
                            EnemyRefreshTick = EnemyRefresh;
                        }
                        else
                        {
                            EnemyRefreshTick--;
                        }
                    }

                    if (Enemies.Count == 0)
                    {
                        return;
                    }

                    for (int i = Enemies.Count - 1; i > 0; i--)
                    {
                        if (Enemies[i].NeedsRemoving)
                        {

                            Enemies.RemoveAt(i);
                        }
                        else
                        {
                            Enemies[i].Update();
                        }
                    }

                    ThreadCompleted[2] = true;
                }


            } while (isRunningThread);


            
        }
        void EnemyDraw()
            {
                for (int i = Enemies.Count - 1; i > 0; i--)
                {
                    Enemies[i].Draw();
                }         
            }

        static void BossUpdate()
        {
            do
            {
                if (BossSpawned)
                {
             
                    if (ThreadCompleted[3] == false)
                    {
                        if (BossEnemy.Life <= 0)
                    {
                        score += 2500;
                        BossKilled += 1;
                        BossSpawned = false;
                        EnemyRefresh = EnemyRefreshHolder;
                        SpawnBoss += 25000;

                    }
                        else
                    {
                        BossEnemy.Update();
                    }

                        ThreadCompleted[3] = true;
                    }
                }

            } while (isRunningThread);       
        }
        void BossDraw()
        {
            BossEnemy.Draw();

        }

        void GameDraw()
            {
                if (!BossSpawned)
                {
                    if (score >= ChangeEnemyRefresh)
                    {
                        if (EnemyRefresh == 0)
                        {
    
                        }
                        else
                        {
                            EnemyRefresh--;
                            ChangeEnemyRefresh += 3000;
                        }

                    }
                }
                
                if (score >= SpawnBoss)
                {
                    if (EnemyRefresh != 5000)
                    {
                        EnemyRefreshHolder = EnemyRefresh;
                        EnemyRefresh = 5000;
                        ChangeEnemyRefresh += 3000;
                        BossEnemy = new Boss(level);
                        BossSpawned = true;
                    }                                    
                }

                if (BossSpawned)
                {
                    _gr.FillRectangle(Brushes.Red,200,5,BossEnemy.Life,10);
                }

                for (int i = 0; i < Ship.PlayerLives; i++)
                {
                    Hearts[i].Update();
                    Hearts[i].Draw();
                }


                _gr.DrawString("Score:" + score, Font, Brushes.White, 0, 50);
                _gr.DrawString("FPS:" + _tMax, Font, Brushes.White, 600, 0);
                _gr.DrawString("Enemy Refresh:" + EnemyRefresh, Font, Brushes.White, 600, 10);

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
        void WriteToLogs()
        {
            string path = Application.StartupPath + @"\Logs";

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, @"Player\Bullets.txt")))
            {
                foreach (var i in Ship.BulletList)
                {
                    outputFile.WriteLine(i + ", " + i.Location + ", " + i.Bounds);
                }
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, @"Enemy\Enemy.txt")))
            {
                if (Enemies.Count == 0)
                {
                    
                }
                else
                { 
                    for (int i = Enemies.Count - 1; i > 0; i--)
                    {
                        outputFile.WriteLine("Enemy:" + i + ", " + Enemies[i].EnemyLoc + ", " + Enemies[i].Bounds +
                                             ", " + Enemies[i].Rarity);
                    }
                }
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, @"Enemy\Bullets.txt")))
            {
                if (Enemies.Count == 0)
                {

                }
                else
                {
                    for (int i = Enemies.Count - 1; i > 0; i--)
                    {
                        outputFile.WriteLine("Enemy: " + i);
                        if (Enemies[i].BulletList.Count == 0)
                        {

                        }
                        else
                        {
                            for (int j = Enemies[i].BulletList.Count - 1; j > 0; j--)
                            {
                                outputFile.WriteLine(Enemies[i].BulletList[j].Location + ", " + Enemies[i].BulletList[j].Bounds);
                            }
                        }
                        
                    }
                }
                
                
            }
        }

        private void ControlBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Movement[0] = true;
            }

            if (e.KeyCode == Keys.S)
            {
                Movement[1] = true;
            }

            if (e.KeyCode == Keys.A)
            {
                Movement[2] = true;
            }

            if (e.KeyCode == Keys.D)
            {
                Movement[3] = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                Fire = true;
            }

            if (e.KeyCode == Keys.X)
            {
                if (SpecialFired == false)
                {
                    SpecialFired = true;
                    Ship.SpecialFired = true;
                    Ship.CreateSpecial();
                }             
            }
            if (e.KeyCode == Keys.P)
            {
                if (Pause)
                {
                    Pause = false;
                    Continue.Enabled = false;
                    Continue.Visible = false;

                    Options.Enabled = false;
                    Options.Visible = false;

                    Help.Enabled = false;
                    Help.Visible = false;

                    Quit.Enabled = false;
                    Quit.Visible = false;

                }
                else
                {
                    Pause = true;
                    Continue.Enabled = true;
                    Continue.Visible = true;

                    Options.Enabled = true;
                    Options.Visible = true;

                    Help.Enabled = true;
                    Help.Visible = true;

                    Quit.Enabled = true;
                    Quit.Visible = true;
                }

            }
        }
        private void ControlBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Movement[0] = false;
            }

            if (e.KeyCode == Keys.S)
            {
                Movement[1] = false;
            }

            if (e.KeyCode == Keys.A)
            {
                Movement[2] = false;
            }

            if (e.KeyCode == Keys.D)
            {
                Movement[3] = false;
            }

            if (e.KeyCode == Keys.Space)
            {
                Fire = false;
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        private void Continue_Click(object sender, EventArgs e)
        {
            Pause = false;
            Continue.Enabled = false;
            Continue.Visible = false;

            Options.Enabled = false;
            Options.Visible = false;

            Help.Enabled = false;
            Help.Visible = false;

            Quit.Enabled = false;
            Quit.Visible = false;
        }

    }
}