using System.Drawing;

namespace GDI__Game
{
    class Heart
    {
        private Point Loc;
        private int FrameNum;
        private Bitmap image;

        public Heart(int Num)
        {
            switch (Num)
            {
                case 1:
                    Loc = new Point(0,0);
                    FrameNum = 1;
                    break;

                case 2:
                    Loc = new Point(32, 0);
                    FrameNum = 1;
                    break;

                case 3:
                    Loc = new Point(64, 0);
                    FrameNum = 1;
                    break;

                case 4:
                    Loc = new Point(96, 0);
                    FrameNum = 1;
                    break;

                case 5:
                    Loc = new Point(128, 0);
                    FrameNum = 1;
                    break;

                case 6:
                    Loc = new Point(0, 32);
                    FrameNum = 1;
                    break;

                case 7:
                    Loc = new Point(32, 32);
                    FrameNum = 1;
                    break;

                case 8:
                    Loc = new Point(64, 32);
                    FrameNum = 1;
                    break;

                case 9:
                    Loc = new Point(96, 32);
                    FrameNum = 1;
                    break;

                case 10:
                    Loc = new Point(128, 32);
                    FrameNum = 1;
                    break;
            }

            image = new Bitmap(Properties.Resources.Heart_Frame_1);
            image.MakeTransparent(Color.Fuchsia);
        }

        public void Update()
        {
            switch (FrameNum)
            {
                case 1:
                    image = new Bitmap(Properties.Resources.Heart_Frame_1);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 2:
                    image = new Bitmap(Properties.Resources.Heart_Frame_2);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 3:
                    image = new Bitmap(Properties.Resources.Heart_Frame_3);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 4:
                    image = new Bitmap(Properties.Resources.Heart_Frame_4);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 5:
                    image = new Bitmap(Properties.Resources.Heart_Frame_5);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 6:
                    image = new Bitmap(Properties.Resources.Heart_Frame_6);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 7:
                    image = new Bitmap(Properties.Resources.Heart_Frame_7);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 8:
                    image = new Bitmap(Properties.Resources.Heart_Frame_8);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 9:
                    image = new Bitmap(Properties.Resources.Heart_Frame_9);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 10:
                    image = new Bitmap(Properties.Resources.Heart_Frame_10);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 11:
                    image = new Bitmap(Properties.Resources.Heart_Frame_11);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 12:
                    image = new Bitmap(Properties.Resources.Heart_Frame_12);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 13:
                    image = new Bitmap(Properties.Resources.Heart_Frame_13);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 14:
                    image = new Bitmap(Properties.Resources.Heart_Frame_14);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 15:
                    image = new Bitmap(Properties.Resources.Heart_Frame_15);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 16:
                    image = new Bitmap(Properties.Resources.Heart_Frame_16);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 17:
                    image = new Bitmap(Properties.Resources.Heart_Frame_17);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 18:
                    image = new Bitmap(Properties.Resources.Heart_Frame_18);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 19:
                    image = new Bitmap(Properties.Resources.Heart_Frame_19);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 20:
                    image = new Bitmap(Properties.Resources.Heart_Frame_20);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 21:
                    image = new Bitmap(Properties.Resources.Heart_Frame_21);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++; ;
                    break;

                case 22:
                    image = new Bitmap(Properties.Resources.Heart_Frame_22);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum++;
                    break;

                case 23:
                    image = new Bitmap(Properties.Resources.Heart_Frame_23);
                    image.MakeTransparent(Color.Fuchsia);
                    FrameNum = 1;
                    break;
            }
        }
        public void Draw()
        {
            Game._gr.DrawImage(image,Loc);
        }
    }
}