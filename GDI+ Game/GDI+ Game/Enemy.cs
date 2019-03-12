using System;
using System.Collections.Generic;
using System.Drawing;

namespace GDI__Game
{
    public class Enemy
    {
        Random r = new Random();

        public Bitmap EnemyPic { get; set; }
        private Size EnemySize = new Size(32,32);
        public Point EnemyLoc { get; set; }
        public Rectangle Bounds { get; set; }
        public List<Bullet> BulletList = new List<Bullet>();
        private int Speed = 1;

        private int BulletRefresh = 0;
        public int Rarity;
        public int lives;
        int RarityThatCanUseBullets;
        public bool NeedsRemoving = false;
        private bool PartOfBoss;

        public bool StartExplosion = false;
        private int ExplosionRefresh = 0;
        private int CurrentFrameNum = 0;
        private Bitmap CurrentFrame;

        public bool WhiteOn;
        public int WhiteFrame;


        public Enemy(int RarityNeeded)
        {
            RarityThatCanUseBullets = RarityNeeded;
            PartOfBoss = false;
            Point Temp = new Point();
            Temp.X = r.Next(0, 736);
            Temp.Y = -64;
            EnemyLoc = Temp;

            int RandTemp = r.Next(1, 102);

            if (RandTemp <= 50)
            {
                EnemyPic = Properties.Resources.Enemy_1;
                EnemyPic.MakeTransparent(Color.Fuchsia);
                EnemySize = new Size(32, 32);
                Rarity = 1;
                lives = 1;
            }
            else if (RandTemp > 50 && RandTemp <= 75)
            {
                EnemyPic = Properties.Resources.Enemy_1;
                EnemyPic.MakeTransparent(Color.Fuchsia);
                EnemySize = new Size(32, 32);
                Rarity = 2;
                lives = 2;
            }
            else if (RandTemp > 75 && RandTemp <= 80)
            {
                EnemyPic = Properties.Resources.Enemy_2;
                EnemyPic.MakeTransparent(Color.Fuchsia);
                EnemySize = new Size(32, 32);
                Rarity = 3;
                lives = 3;
            }
            else if (RandTemp > 80 && RandTemp <= 89)
            {
                EnemyPic = Properties.Resources.Enemy_3;
                EnemyPic.MakeTransparent(Color.Fuchsia);
                EnemySize = new Size(32, 32);
                Speed = 2;
                Rarity = 4;
                lives = 4;
            }
            else if (RandTemp > 89 && RandTemp <= 95)
            {
                EnemyPic = Properties.Resources.Enemy_4;
                EnemyPic.MakeTransparent(Color.Fuchsia);
                EnemySize = new Size(32, 32);
                Rarity = 5;
                lives = 5;
            }
            else if (RandTemp > 95 && RandTemp <= 99)
            {
                EnemyPic = Properties.Resources.Enemy_5;
                EnemyPic.MakeTransparent(Color.Fuchsia);
                EnemySize = new Size(32, 32);
                BulletRefresh = 50;
                Rarity = 6;
                lives = 6;
            }
            else if (RandTemp >= 100)
            {
                EnemyPic = Properties.Resources.Enemy_6;
                EnemyPic.MakeTransparent(Color.Fuchsia);
                EnemySize = new Size(64,64);
                BulletRefresh = 40;
                Rarity = 7;
                lives = 7;
            }

            Bounds = new Rectangle(Temp, EnemySize);
        }

        public Enemy(Point Loc, int rarityNum, int RarityNeeded)
        {
            RarityThatCanUseBullets = RarityNeeded;

            EnemyLoc = Loc;
            Rarity = rarityNum;
            PartOfBoss = true;
            switch (Rarity)
            {
                case 1:
                    EnemyPic = Properties.Resources.Enemy_1;
                    break;
                case 2:
                    EnemyPic = Properties.Resources.Enemy_1;
                    break;
                case 3:
                    EnemyPic = Properties.Resources.Enemy_2;
                    break;
                case 4:
                    EnemyPic = Properties.Resources.Enemy_3;
                    break;
                case 5:
                    EnemyPic = Properties.Resources.Enemy_4;
                    break;
                case 6:
                    EnemyPic = Properties.Resources.Enemy_5;
                    break;
                case 7:
                    EnemyPic = Properties.Resources.Enemy_6;
                    break;
            }
            Bounds = new Rectangle(Loc, EnemySize);


        }

        public void Update()
        {
            if (NeedsRemoving)
            {
                return;
            }

            if (StartExplosion)
            {
                if (ExplosionRefresh != 0)
                {
                    BulletRefresh -= 1;
                }
                else
                {
                    CurrentFrameNum++;
                    switch (CurrentFrameNum)
                    {
                        case 1:
                            CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_1);
                            CurrentFrame.MakeTransparent(Color.Black);
                            BulletRefresh = 15;
                            break;
                        case 2:
                            CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_2);
                            CurrentFrame.MakeTransparent(Color.Black);
                            BulletRefresh = 15;
                            break;
                        case 3:
                            CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_3);
                            CurrentFrame.MakeTransparent(Color.Black);
                            BulletRefresh = 15;
                            break;
                        case 4:
                            CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_4);
                            CurrentFrame.MakeTransparent(Color.Black);
                            BulletRefresh = 15;
                            break;
                        case 5:
                            CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_5);
                            CurrentFrame.MakeTransparent(Color.Black);
                            BulletRefresh = 15;
                            break;
                        case 6:
                            CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_6);
                            CurrentFrame.MakeTransparent(Color.Black);
                            BulletRefresh = 15;
                            break;
                        case 7:
                            CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_7);
                            CurrentFrame.MakeTransparent(Color.Black);
                            BulletRefresh = 15;
                            break;
                        case 8:
                            CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Explosion_Frame_8);
                            CurrentFrame.MakeTransparent(Color.Black);
                            NeedsRemoving = true;
                            break;
                    }

                    Game._gr.DrawImage(CurrentFrame, EnemyLoc);
                }

                return;
            }

            if (Game.Ship.b.BlackholeEnabled)
            {       
                if (Bounds.IntersectsWith(Game.Ship.b.Bounds[0]))
            {
                NeedsRemoving = true;
            }

                if (Bounds.IntersectsWith(Game.Ship.b.Bounds[3]))
            {
                Speed = 2;

                if (EnemyLoc.X > Game.Ship.b.SpecialLoc.X + 64 && EnemyLoc.Y > Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = EnemyLoc;
                    _temp.X -= 1;
                    EnemyLoc = _temp;
                }
                else if (EnemyLoc.X > Game.Ship.b.SpecialLoc.X + 64 && EnemyLoc.Y < Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = EnemyLoc;
                    _temp.X -= 1;
                    EnemyLoc = _temp;
                }
                else if (EnemyLoc.X < Game.Ship.b.SpecialLoc.X + 64 && EnemyLoc.Y > Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = EnemyLoc;
                    _temp.X += 1;
                    EnemyLoc = _temp;
                }
                else if (EnemyLoc.X < Game.Ship.b.SpecialLoc.X + 64 && EnemyLoc.Y < Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = EnemyLoc;
                    _temp.X += 1;
                    EnemyLoc = _temp;
                }

            }

                if (Bounds.IntersectsWith(Game.Ship.b.Bounds[2]))
            {
                Speed = 3;

                if (EnemyLoc.X > Game.Ship.b.SpecialLoc.X + 64 && EnemyLoc.Y > Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = EnemyLoc;
                    _temp.X -= 2;
                    EnemyLoc = _temp;
                }
                else if (EnemyLoc.X > Game.Ship.b.SpecialLoc.X + 64 && EnemyLoc.Y < Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = EnemyLoc;
                    _temp.X -= 2;
                    EnemyLoc = _temp;
                }
                else if (EnemyLoc.X < Game.Ship.b.SpecialLoc.X + 64 && EnemyLoc.Y > Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = EnemyLoc;
                    _temp.X += 2;
                    EnemyLoc = _temp;
                }
                else if (EnemyLoc.X < Game.Ship.b.SpecialLoc.X + 64 && EnemyLoc.Y < Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = EnemyLoc;
                    _temp.X += 2;
                    EnemyLoc = _temp;
                }
            }

                if (Bounds.IntersectsWith(Game.Ship.b.Bounds[1]))
            {
                Speed = 4;

                if (EnemyLoc.X > Game.Ship.b.SpecialLoc.X + 64 && EnemyLoc.Y > Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = EnemyLoc;
                    _temp.X -= 2;
                    EnemyLoc = _temp;
                }
                else if (EnemyLoc.X > Game.Ship.b.SpecialLoc.X + 64 && EnemyLoc.Y < Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = EnemyLoc;
                    _temp.X -= 2;
                    EnemyLoc = _temp;
                }
                else if (EnemyLoc.X < Game.Ship.b.SpecialLoc.X + 64 && EnemyLoc.Y > Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = EnemyLoc;
                    _temp.X += 2;
                    EnemyLoc = _temp;
                }
                else if (EnemyLoc.X < Game.Ship.b.SpecialLoc.X + 64 && EnemyLoc.Y < Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = EnemyLoc;
                    _temp.X += 2;
                    EnemyLoc = _temp;
                }
            }

                if (!Bounds.IntersectsWith(Game.Ship.b.Bounds[1]) && !Bounds.IntersectsWith(Game.Ship.b.Bounds[2]) &&
                !Bounds.IntersectsWith(Game.Ship.b.Bounds[3]))
            {
                Speed = 1;
            }
            }

            if (!Game.Ship.b.BlackholeEnabled)
            {
                Speed = 1;
            }

            if (EnemyLoc.X >= 1000)
            {
                Game.Ship.PlayerLives -= 1;
                NeedsRemoving = true;
            }
            else
            {
                
                if (WhiteOn)
                {
                    if (WhiteFrame == 0)
                    {
                        WhiteOn = false;
                    }
                    else
                    {
                        switch (Rarity)
                        {
                            case 1:
                                EnemyPic = Properties.Resources.Enemy_1_White;
                                break;
                            case 2:
                                EnemyPic = Properties.Resources.Enemy_1_White;
                                break;
                            case 3:
                                EnemyPic = Properties.Resources.Enemy_2_White;
                                break;
                            case 4:
                                EnemyPic = Properties.Resources.Enemy_3_White;
                                break;
                            case 5:
                                EnemyPic = Properties.Resources.Enemy_4_White;
                                break;
                            case 6:
                                EnemyPic = Properties.Resources.Enemy_5_White;
                                break;
                            case 7:
                                EnemyPic = Properties.Resources.Enemy_6_White;
                                break;
                        }
                        EnemyPic.MakeTransparent(Color.Fuchsia);
                        WhiteFrame--;
                    }
                }
                else
                {
                    switch (Rarity)
                    {
                        case 1:
                            EnemyPic = Properties.Resources.Enemy_1;
                            break;
                        case 2:
                            EnemyPic = Properties.Resources.Enemy_1;
                            break;
                        case 3:
                            EnemyPic = Properties.Resources.Enemy_2;
                            break;
                        case 4:
                            EnemyPic = Properties.Resources.Enemy_3;
                            break;
                        case 5:
                            EnemyPic = Properties.Resources.Enemy_4;
                            break;
                        case 6:
                            EnemyPic = Properties.Resources.Enemy_5;
                            break;
                        case 7:
                            EnemyPic = Properties.Resources.Enemy_6;
                            break;
                    }
                    EnemyPic.MakeTransparent(Color.Fuchsia);
                }
              
                if (PartOfBoss)
                {
                    Point Temp = Game.BossEnemy.BossLoc;
                    Temp.Y += Game.BossEnemy.BossSize.Height / 2;
                    Temp.X += Game.BossEnemy.BossSize.Width / 2;

                    var TempLoc = EnemyLoc;

                    if (EnemyLoc.X <= Temp.X && EnemyLoc.Y <= Temp.Y)
                    {                      
                        TempLoc.X -= 3;
                        TempLoc.Y += 3;
                    }
                    else if (EnemyLoc.X <= Temp.X && EnemyLoc.Y >= Temp.Y)
                    {
                        TempLoc.X += 3;
                        TempLoc.Y += 3;
                    }
                    else if (EnemyLoc.X >= Temp.X && EnemyLoc.Y <= Temp.Y)
                    {
                        TempLoc.X -= 3;
                        TempLoc.Y -= 3;
                    }
                    else if (EnemyLoc.X >= Temp.X && EnemyLoc.Y >= Temp.Y)
                    {
                        TempLoc.X += 3;
                        TempLoc.Y -= 3;
                    }

                    EnemyLoc = TempLoc;
                    Bounds = new Rectangle(TempLoc, EnemySize);
                }
                else
                {
                    Point Temp = EnemyLoc;
                    Temp.Y += Speed;
                    EnemyLoc = Temp;
                    Bounds = new Rectangle(Temp, EnemySize);
                }
                
            }

            UpdateBullets();
            Draw();            
        }
        public void Draw()
        {
            if (Game.ShowBounds)
            {
                Game._gr.DrawRectangle(Pens.Red, Bounds);
            }

            Game._gr.DrawImage(EnemyPic, EnemyLoc);
        }

        void UpdateBullets()
        {
            

            if (BulletRefresh == 0 && Rarity >= RarityThatCanUseBullets)
            {
                BulletList.Add(new Bullet(EnemyLoc, "Enemy"));
                BulletRefresh = 100;
            }
            else
            {
                BulletRefresh--;
            }

            if (BulletList.Count == 0)
            {
                return;
            }

            for (int i = BulletList.Count; i > 0; )
            {
                if (BulletList[i - 1].NeedsRemoving)
                {

                    BulletList.RemoveAt(i - 1);
                }
                else
                {
                    BulletList[i - 1].Update();
                    BulletList[i - 1].Draw();
                }

                i--;
            }
        }
    }
}