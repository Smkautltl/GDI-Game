using System.Collections.Generic;
using System.Drawing;

namespace GDI__Game
{
    public class Player
    {
        public Bitmap PlayerPic { get; set;}
        public Point PlayerLoc { get; set; } = new Point(400, 800);
        public Rectangle Bounds { get; set; }
        public Size PlayerSize { get; set; }

        public List<Bullet> BulletList = new List<Bullet>();
        public int PlayerLives { get; set; }
       
        public Bitmap SpecialBullet;
        private Point SpecialLoc;
        private int SpecialBulletNum = 0;
        public bool SpecialFired = false;
        private Color SpecialBackColour = Color.FromArgb(0, 75, 178, 81);
        public Blackhole b = new Blackhole();

        public Player(Bitmap StartPic)
        {
            PlayerPic = StartPic;
            PlayerSize = StartPic.Size;
            Bounds = new Rectangle(PlayerLoc, PlayerSize);
            PlayerLives = 3;
        }

        public void CreateBullet()
        {
            BulletList.Add(new Bullet(PlayerLoc, "Player"));
        }
        public void UpdateBullets()
        {
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
                }

                i--;
            }

            BulletDraw();
        }
        public void BulletDraw()
        {
            for (int i = BulletList.Count; i > 0;)
            {
                BulletList[i - 1].Draw();
                i--;
            }
        }

        public void CreateSpecial()
        {
            SpecialLoc = PlayerLoc;
            SpecialLoc.X += PlayerSize.Width / 2;
            SpecialLoc.Y += PlayerSize.Height / 2;

            SpecialLoc.X -= 32;
            SpecialLoc.Y -= 32;

            SpecialBullet = Properties.Resources.SpecialBullet__Frame_1;
            SpecialBullet.MakeTransparent(SpecialBackColour);
            Game._gr.DrawImage(SpecialBullet,SpecialLoc);
            SpecialFired = true;
        }
        public void UpdateSpecialBullet()
        {
            if (SpecialFired)
            {
                if (SpecialLoc.Y <= 150)
                {
                    b.Update(SpecialLoc);
                    return;
                }


                SpecialBulletNum++;
                switch (SpecialBulletNum)
                {
                    case 1:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_1;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 2:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_2;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 3:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_3;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 4:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_4;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 5:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_5;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 6:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_6;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 7:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_7;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 8:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_8;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 9:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_9;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 10:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_10;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 11:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_11;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 12:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_12;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 13:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_13;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 14:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_14;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 15:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_15;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 16:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_16;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 17:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_17;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        break;

                    case 18:
                        SpecialBullet = Properties.Resources.SpecialBullet__Frame_18;
                        SpecialBullet.MakeTransparent(SpecialBackColour);
                        SpecialLoc.Y -= 3;
                        DrawSpecialBullet();
                        SpecialBulletNum = 0;
                        break;

                }
            }         
        }
        public void DrawSpecialBullet()
        {
            if (SpecialFired && b.BlackholeEnabled == false)
            {
                Game._gr.DrawImage(SpecialBullet, SpecialLoc);
            }
        }
    }
}