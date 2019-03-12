using System.Drawing;

namespace GDI__Game
{
    public class Blackhole
    {
        public Bitmap SpecialBullet;
        public Point SpecialLoc;
        private int SpecialBulletNum = 0;
        public bool BlackholeEnabled = false;
        private bool MoveBlackhole = false;
        private Color BlackColour = Color.FromArgb(255, 20, 20, 20);
        private int BlackHoleDuration = 1000;

        public Rectangle[] Bounds = new Rectangle[4];

        public void Update(Point Loc)
        {
            if (BlackholeEnabled == false)
            {
                SpecialLoc = Loc;
                BlackholeEnabled = true;
                Bounds[0] = new Rectangle(SpecialLoc, new Size(128,128));

                Point Temp = SpecialLoc;
                Temp.X -= 20;
                Temp.Y -= 20;
                Bounds[1] = new Rectangle(Temp, new Size(128+40,128+40));

                Temp.X -= 20;
                Temp.Y -= 20;
                Bounds[2] = new Rectangle(Temp, new Size(128 + 80, 128 + 80));

                Temp.X -= 20;
                Temp.Y -= 20;
                Bounds[3] = new Rectangle(Temp, new Size(128 + 120, 128 + 120));

            }

            if (BlackHoleDuration == 0)
            {
                Game.Ship.SpecialFired = false;
                BlackholeEnabled = false;
                BlackHoleDuration = 1000;
                return;
            }

            if (MoveBlackhole == false)
            {
                SpecialLoc.X -= 48;
                SpecialLoc.Y -= 48;
                MoveBlackhole = true;

                Bounds[0] = new Rectangle(SpecialLoc, new Size(128, 128));

                Point Temp = SpecialLoc;
                Temp.X -= 30;
                Temp.Y -= 30;
                Bounds[1] = new Rectangle(Temp, new Size(128 + 60, 128 + 60));

                Temp.X -= 30;
                Temp.Y -= 30;
                Bounds[2] = new Rectangle(Temp, new Size(128 + 120, 128 + 120));

                Temp.X -= 30;
                Temp.Y -= 30;
                Bounds[3] = new Rectangle(Temp, new Size(128 + 180, 128 + 180));
            }

            if (Game.ShowBounds)
            {
                Game._gr.DrawRectangle(Pens.Red,Bounds[0]);
                Game._gr.DrawRectangle(Pens.Red,Bounds[1]);
                Game._gr.DrawRectangle(Pens.Red,Bounds[2]);
                Game._gr.DrawRectangle(Pens.Red,Bounds[3]);
            }

            SpecialBulletNum++;
            switch (SpecialBulletNum)
            {
                case 1:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_01;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 2:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_02;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 3:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_03;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 4:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_04;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 5:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_05;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 6:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_06;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 7:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_07;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 8:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_08;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 9:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_09;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 10:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_10;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 11:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_11;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 12:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_12;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 13:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_13;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 14:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_14;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 15:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_15;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 16:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_16;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 17:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_17;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 18:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_18;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 19:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_19;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 20:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_20;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 21:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_21;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 22:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_22;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 23:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_23;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 24:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_24;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 25:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_25;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 26:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_26;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 27:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_27;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 28:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_28;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 29:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_29;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    break;

                case 30:
                    SpecialBullet = Properties.Resources.Blackhole_Frame_30;
                    SpecialBullet.MakeTransparent(BlackColour);
                    Game._gr.DrawImage(SpecialBullet, SpecialLoc);
                    SpecialBulletNum = 0;
                    break;
            }

            BlackHoleDuration--;
        }
    }
}
