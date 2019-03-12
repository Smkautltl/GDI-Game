using System;
using System.Collections.Generic;
using System.Drawing;

namespace GDI__Game
{
    public class Boss
    {
        Bitmap BossPic { get; set; }
        public Size BossSize;
        public Point BossLoc { get; set; }
        public Rectangle Bounds { get; set; }
        public List<Enemy> EnemiesList = new List<Enemy>();
        public List<Bullet> BulletList = new List<Bullet>();
        private int bulletrate;

        public int Life;
        private int level;

        public bool StartExplosion;
        private int ExplosionRefresh;
        private int CurrentFrameNum;
        private Bitmap[] ExplosionFrame = new Bitmap[3];
        Point[] ExplosionLoc = new Point[3];

        private bool StartBigExplosion;
        private Bitmap BigExplosionFrame;
        private int BigExplosionRefresh;
        private int CurrentBigFrameNum;

        public Boss(int BossLevel)
        {
            level = BossLevel;
            switch (BossLevel)
            {
                case 1:
                    BossPic = Properties.Resources.Boss_1;
                    BossPic.MakeTransparent(Color.Fuchsia);
                    BossSize = new Size(128, 128);
                    BossLoc = new Point(336, -200);
                    bulletrate = 15;
                    Life = 50;
                    break;

                case 2:
                    BossPic = Properties.Resources.Boss_2;
                    BossPic.MakeTransparent(Color.Fuchsia);
                    BossSize = new Size(128, 128);
                    BossLoc = new Point(336, -200);
                    bulletrate = 13;
                    Life = 60;
                    break;

                case 3:
                    BossPic = Properties.Resources.Boss_3;
                    BossPic.MakeTransparent(Color.Fuchsia);
                    BossSize = new Size(128, 128);
                    BossLoc = new Point(336, -200);
                    bulletrate = 11;
                    Life = 70;
                    break;

                case 4:
                    BossPic = Properties.Resources.Boss_4;
                    BossPic.MakeTransparent(Color.Fuchsia);
                    BossSize = new Size(128, 128);
                    BossLoc = new Point(336, -200);
                    bulletrate = 9;
                    Life = 80;
                    break;

                case 5:
                    BossPic = Properties.Resources.Boss_5;
                    BossPic.MakeTransparent(Color.Fuchsia);
                    BossSize = new Size(128, 128);
                    BossLoc = new Point(336, -200);
                    bulletrate = 7;
                    Life = 90;
                    break;

                case 6:
                    BossPic = Properties.Resources.Boss_6;
                    BossPic.MakeTransparent(Color.Fuchsia);
                    BossSize = new Size(128, 128);
                    BossLoc = new Point(336, -200);
                    bulletrate = 5;
                    Life = 100;
                    break;

                case 7:
                    BossPic = Properties.Resources.Boss_7;
                    BossPic.MakeTransparent(Color.Fuchsia);
                    BossSize = new Size(160, 160);
                    BossLoc = new Point(320, -200);
                    bulletrate = 3;
                    Life = 150;
                    break;

                case 8:
                    BossPic = Properties.Resources.Boss_8;
                    BossPic.MakeTransparent(Color.Fuchsia);
                    BossSize = new Size(160, 160);
                    BossLoc = new Point(320, -200);
                    bulletrate = 1;
                    Life = 200;
                    break;

            }

            Bounds = new Rectangle(BossLoc, BossSize);

            Point Temp = BossLoc;
            Temp.Y -= 64;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));
            Temp.X += 32;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));
            Temp.X += 32;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));
            Temp.X += 32;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));

            Temp = BossLoc;
            Temp.X -= 64;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));
            Temp.Y += 32;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));
            Temp.Y += 32;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));
            Temp.Y += 32;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));

            Temp = BossLoc;
            Temp.Y += BossSize.Height + 32;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));
            Temp.X += 32;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));
            Temp.X += 32;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));
            Temp.X += 32;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));

            Temp = BossLoc;
            Temp.X += BossSize.Width + 32;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));
            Temp.Y += 32;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));
            Temp.Y += 32;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));
            Temp.Y += 32;
            EnemiesList.Add(new Enemy(Temp, BossLevel, Game.RarityThatCanUseBullets));
        }

        public void Update()
        {
            for (int i = EnemiesList.Count - 1; i > 0; i--)
            {
                if (EnemiesList[i].NeedsRemoving)
                {

                    EnemiesList.RemoveAt(i);
                }
                else
                {
                    EnemiesList[i].Update();
                }
            }

            if (StartExplosion)
            {
                if (ExplosionRefresh != 0)
                {
                    ExplosionRefresh -= 1;
                }
                else
                {
                    Point Temp = BossLoc;
                    Random R = new Random();

                    CurrentFrameNum++;
                    switch (CurrentFrameNum)
                    {
                        case 1:
                            Temp.X = R.Next(BossLoc.X, BossLoc.X + BossSize.Width);
                            Temp.Y = R.Next(BossLoc.Y, BossLoc.Y + BossSize.Height);
                            ExplosionLoc[0] = Temp;

                            ExplosionFrame[0] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_1);
                            ExplosionFrame[0].MakeTransparent(Color.Black);

                            ExplosionRefresh = 5;
                            break;

                        case 2:
                            ExplosionFrame[0] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_2);
                            ExplosionFrame[0].MakeTransparent(Color.Black);

                            Temp.X = R.Next(BossLoc.X, BossLoc.X + BossSize.Width);
                            Temp.Y = R.Next(BossLoc.Y, BossLoc.Y + BossSize.Height);
                            ExplosionLoc[1] = Temp;

                            ExplosionFrame[1] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_1);
                            ExplosionFrame[1].MakeTransparent(Color.Black);

                            ExplosionRefresh = 5;
                            break;

                        case 3:
                            ExplosionFrame[0] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_3);
                            ExplosionFrame[0].MakeTransparent(Color.Black);
                            ExplosionFrame[1] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_2);
                            ExplosionFrame[1].MakeTransparent(Color.Black);

                            Temp.X = R.Next(BossLoc.X, BossLoc.X + BossSize.Width);
                            Temp.Y = R.Next(BossLoc.Y, BossLoc.Y + BossSize.Height);
                            ExplosionLoc[2] = Temp;

                            ExplosionFrame[2] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_1);
                            ExplosionFrame[2].MakeTransparent(Color.Black);

                            ExplosionRefresh = 5;
                            break;

                        case 4:
                            ExplosionFrame[0] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_4);
                            ExplosionFrame[0].MakeTransparent(Color.Black);
                            ExplosionFrame[1] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_3);
                            ExplosionFrame[1].MakeTransparent(Color.Black);
                            ExplosionFrame[2] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_2);
                            ExplosionFrame[2].MakeTransparent(Color.Black);


                            ExplosionRefresh = 5;
                            break;
                        case 5:
                            ExplosionFrame[0] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_5);
                            ExplosionFrame[0].MakeTransparent(Color.Black);
                            ExplosionFrame[1] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_4);
                            ExplosionFrame[1].MakeTransparent(Color.Black);
                            ExplosionFrame[2] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_3);
                            ExplosionFrame[2].MakeTransparent(Color.Black);
                            StartBigExplosion = true;
                            ExplosionRefresh = 5;
                            break;
                        case 6:
                            ExplosionFrame[0] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_6);
                            ExplosionFrame[0].MakeTransparent(Color.Black);
                            ExplosionFrame[1] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_5);
                            ExplosionFrame[1].MakeTransparent(Color.Black);
                            ExplosionFrame[2] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_4);
                            ExplosionFrame[2].MakeTransparent(Color.Black);
                            ExplosionRefresh = 5;
                            break;

                        case 7:
                            ExplosionFrame[1] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_6);
                            ExplosionFrame[1].MakeTransparent(Color.Black);
                            ExplosionFrame[2] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_5);
                            ExplosionFrame[2].MakeTransparent(Color.Black);
                            ExplosionRefresh = 5;
                            break;

                        case 8:
                            ExplosionFrame[2] = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_6);
                            ExplosionFrame[2].MakeTransparent(Color.Black);
                            StartExplosion = false;
                            break;
                    }

                    if (CurrentFrameNum == 7)
                    {
                        Game._gr.DrawImage(ExplosionFrame[1], ExplosionLoc[1]);
                        Game._gr.DrawImage(ExplosionFrame[2], ExplosionLoc[2]);
                    }
                    else if (CurrentFrameNum == 8)
                    {
                        Game._gr.DrawImage(ExplosionFrame[2], ExplosionLoc[2]);
                    }
                    else if (CurrentFrameNum == 1)
                    {
                        Game._gr.DrawImage(ExplosionFrame[0], ExplosionLoc[0]);
                    }
                    else if (CurrentFrameNum == 2)
                    {
                        Game._gr.DrawImage(ExplosionFrame[0], ExplosionLoc[0]);
                        Game._gr.DrawImage(ExplosionFrame[1], ExplosionLoc[1]);
                    }
                    else
                    {
                        Game._gr.DrawImage(ExplosionFrame[0], ExplosionLoc[0]);
                        Game._gr.DrawImage(ExplosionFrame[1], ExplosionLoc[1]);
                        Game._gr.DrawImage(ExplosionFrame[2], ExplosionLoc[2]);
                    }
                }

                if (StartBigExplosion)
                {
                    
                }
                else
                {
                    return;
                }                
            }
            if (StartBigExplosion)
            {
                if (BigExplosionRefresh != 0)
                {
                    BigExplosionRefresh -= 1;
                }
                else
                {

                    CurrentBigFrameNum++;
                    switch (CurrentBigFrameNum)
                    {
                        case 1:


                            BigExplosionFrame = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_1);
                            BigExplosionFrame.MakeTransparent(Color.Black);

                            BigExplosionRefresh = 5;
                            break;

                        case 2:
                            BigExplosionFrame = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_2);
                            BigExplosionFrame.MakeTransparent(Color.Black);
                            BigExplosionRefresh = 5;
                            break;

                        case 3:
                            BigExplosionFrame = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_3);
                            BigExplosionFrame.MakeTransparent(Color.Black);
                            BigExplosionRefresh = 5;
                            break;

                        case 4:
                            BigExplosionFrame = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_4);
                            BigExplosionFrame.MakeTransparent(Color.Black);
                            BigExplosionRefresh = 5;
                            break;
                        case 5:
                            BigExplosionFrame = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_5);
                            BigExplosionFrame.MakeTransparent(Color.Black);
                            BigExplosionRefresh = 5;
                            break;
                        case 6:
                            BigExplosionFrame = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_6);
                            BigExplosionFrame.MakeTransparent(Color.Black);
                            Life = 0;
                            StartBigExplosion = false;
                            break;
                    }

                    return;
                }
               
            }

            if (BossLoc.Y <= 64)
            {
                Point Temp = BossLoc;
                Temp.Y += 1;
                BossLoc = Temp;

                for (int i = EnemiesList.Count - 1; i > 0; i--)
                {
                    Temp = EnemiesList[i].EnemyLoc;
                    Temp.Y += 1;
                    EnemiesList[i].EnemyLoc = Temp;
                }
            }
            for (int i = EnemiesList.Count - 1; i > 0; i--)
            {
                EnemiesList[i].Update();
            }

            if (BossLoc.Y >= 64)
            {
                if (bulletrate == 0)
                {
                    BulletList.Add(new Bullet(BossLoc, "Boss"));

                    for (int i = 0; i < BulletList.Count; i++)
                    {
                        BulletList[i].Update();
                    }

                    switch (level)
                    {
                        case 1:
                            bulletrate = 35;
                            break;

                        case 2:
                            bulletrate = 33;
                            break;

                        case 3:
                            bulletrate = 31;
                            break;

                        case 4:
                            bulletrate = 29;
                            break;

                        case 5:
                            bulletrate = 27;
                            break;

                        case 6:
                            bulletrate = 25;
                            break;

                        case 7:
                            bulletrate = 23;
                            break;

                        case 8:
                            bulletrate = 21;
                            break;
                    }

                }
                else
                {
                    if (BulletList.Count == 0)
                    {
                        bulletrate--;
                        return;
                    }

                    for (int i = 0; i < BulletList.Count; i++)
                    {
                        if (BulletList[i].NeedsRemoving)
                        {
                            BulletList.RemoveAt(i);
                        }
                        BulletList[i].Update();
                    }

                    bulletrate--;
                }

            }

            Bounds = new Rectangle(BossLoc, BossSize);
        }

        public void Draw()
        {
            Game._gr.DrawImage(BossPic, BossLoc);

            for (int i = EnemiesList.Count - 1; i > 0; i--)
            {
                EnemiesList[i].Draw();
            }

            if (BulletList.Count == 0)
            {
                return; 
            }

            for (int i = 0; i < BulletList.Count; i++)
            {
                BulletList[i].Draw();
            }
        }
    }
}