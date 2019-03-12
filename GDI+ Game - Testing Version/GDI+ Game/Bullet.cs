using System.Drawing;

namespace GDI__Game
{
    public class Bullet
    {
        private Point _location;
        public Point Location { get; set; }

        private Bitmap _picture;
        public Bitmap Picture { get; set; }

        private string Type;
        public bool NeedsRemoving = false;

        public Rectangle Bounds { get; set; }
        Size BulletSize = new Size(16,16);

        public bool StartExplosion = false;
        private int ExplosionRefresh = 0;
        private int CurrentFrameNum = 0;
        private Bitmap CurrentFrame;

        private int Speed = 9;

        public Bullet(Point TypeLocation, string type)
        {
            Type = type;
            switch (type)
            {
                case "Player":
                    Point temp = TypeLocation;
                    temp.X += 42;
                    temp.Y += 25;
                    Location = temp;
                    Picture = new Bitmap(Properties.Resources.Bullet_Blue);
                    Picture.MakeTransparent(Color.Fuchsia);
                    break;

                case "Enemy":
                    Point temp1 = TypeLocation;
                    temp1.X += 16;
                    temp1.Y += 16;
                    Location = temp1;
                    Picture = new Bitmap(Properties.Resources.Bullet);
                    Picture.MakeTransparent(Color.Fuchsia);
                    break;

                case "Boss":
                    Point temp2 = TypeLocation;
                    temp2.X += 64;
                    temp2.Y += 64;
                    Location = temp2;
                    Picture = new Bitmap(Properties.Resources.Bullet);
                    Picture.MakeTransparent(Color.Fuchsia);
                    break;
            }
        }

        public void Update()
        {
            if (Location.Y < 1000 && Location.Y > 0)
            {
                if (Type == "Player")
                {
                    for (int i = 0; i < Game.Enemies.Count;)
                    {
                        if (StartExplosion)
                        {
                            if (ExplosionRefresh != 0)
                            {
                                ExplosionRefresh -= 1;
                            }
                            else
                            {
                                CurrentFrameNum++;
                                switch (CurrentFrameNum)
                                {
                                    case 1:
                                        CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Small_Explosion_1);
                                        CurrentFrame.MakeTransparent(Color.Fuchsia);
                                        ExplosionRefresh = 1;
                                        break;
                                    case 2:
                                        CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Small_Explosion_2);
                                        CurrentFrame.MakeTransparent(Color.Fuchsia);
                                        ExplosionRefresh = 1;
                                        break;
                                    case 3:
                                        CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Small_Explosion_3);
                                        CurrentFrame.MakeTransparent(Color.Fuchsia);
                                        ExplosionRefresh = 1;
                                        break;
                                    case 4:
                                        CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Small_Explosion_4);
                                        CurrentFrame.MakeTransparent(Color.Fuchsia);
                                        ExplosionRefresh = 1;
                                        break;
                                    case 5:
                                        CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Small_Explosion_5);
                                        CurrentFrame.MakeTransparent(Color.Fuchsia);
                                        ExplosionRefresh = 1;
                                        break;
                                    case 6:
                                        CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Small_Explosion_6);
                                        CurrentFrame.MakeTransparent(Color.Fuchsia);
                                        NeedsRemoving = true;
                                        break;                                
                                }

                                Game._gr.DrawImage(CurrentFrame, Location);
                            }

                            return;
                        }

                        if (Bounds.IntersectsWith(Game.Enemies[i].Bounds))
                        {
                            switch (Game.Enemies[i].lives)
                            {
                                case 1:
                                    Game.Enemies[i].StartExplosion = true;
                                    MakeEnemyWhite(Game.Enemies[i]);                                    
                                    Game.score += 50;
                                    Game.EnemyKilled += 1;
                                    break;

                                case 2:
                                    Game.Enemies[i].lives = 1;
                                    MakeEnemyWhite(Game.Enemies[i]);
                                    Game.score += 60;
                                    break;

                                case 3:
                                    Game.Enemies[i].lives = 2;
                                    MakeEnemyWhite(Game.Enemies[i]);
                                    Game.score += 70;
                                    break;

                                case 4:
                                    Game.Enemies[i].lives = 3;
                                    MakeEnemyWhite(Game.Enemies[i]);
                                    Game.score += 90;
                                    break;

                                case 5:
                                    Game.Enemies[i].lives = 4;
                                    MakeEnemyWhite(Game.Enemies[i]);
                                    Game.score += 100;
                                    break;

                                case 6:
                                    Game.Enemies[i].lives = 5;
                                    MakeEnemyWhite(Game.Enemies[i]);
                                    Game.score += 150;
                                    break;

                                case 7:
                                    Game.Enemies[i].lives = 6;
                                    MakeEnemyWhite(Game.Enemies[i]);
                                    Game.score += 200;
                                    break;

                                default:
                                    Game.Enemies[i].NeedsRemoving = true;
                                    break;
                            }

                            StartExplosion = true;                                                      
                        }
                        i++;
                    }
                    for (int i = 0; i < Game.Enemies.Count;)
                    {
                        for (int j = 0; j < Game.Enemies[i].BulletList.Count; )
                        {
                            if (Bounds.IntersectsWith(Game.Enemies[i].BulletList[j].Bounds))
                            {
                                Game.Enemies[i].BulletList[j].NeedsRemoving = true;
                                NeedsRemoving = true;
                                Game.score += 1;
                            }
                            j++;
                        }
                        i++;
                    }
                                  
                    if (Game.BossSpawned)
                    {
                        if (StartExplosion)
                        {
                            if (ExplosionRefresh != 0)
                            {
                                ExplosionRefresh -= 1;
                            }
                            else
                            {
                                CurrentFrameNum++;
                                switch (CurrentFrameNum)
                                {
                                    case 1:
                                        CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Small_Explosion_1);
                                        CurrentFrame.MakeTransparent(Color.Fuchsia);
                                        ExplosionRefresh = 1;
                                        break;
                                    case 2:
                                        CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Small_Explosion_2);
                                        CurrentFrame.MakeTransparent(Color.Fuchsia);
                                        ExplosionRefresh = 1;
                                        break;
                                    case 3:
                                        CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Small_Explosion_3);
                                        CurrentFrame.MakeTransparent(Color.Fuchsia);
                                        ExplosionRefresh = 1;
                                        break;
                                    case 4:
                                        CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Small_Explosion_4);
                                        CurrentFrame.MakeTransparent(Color.Fuchsia);
                                        ExplosionRefresh = 1;
                                        break;
                                    case 5:
                                        CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Small_Explosion_5);
                                        CurrentFrame.MakeTransparent(Color.Fuchsia);
                                        ExplosionRefresh = 1;
                                        break;
                                    case 6:
                                        CurrentFrame = new Bitmap(GDI__Game.Properties.Resources.Small_Explosion_6);
                                        CurrentFrame.MakeTransparent(Color.Fuchsia);
                                        NeedsRemoving = true;
                                        break;
                                }

                                Game._gr.DrawImage(CurrentFrame, Location);
                            }

                            return;
                        }

                        if (Bounds.IntersectsWith(Game.BossEnemy.Bounds))
                        {                          
                            Game.BossEnemy.Life -= 1;
                            StartExplosion = true;                  

                            if (Game.BossEnemy.Life == 1)
                            {
                                Game.BossEnemy.StartExplosion = true;
                            }
                        }
                        for (int i = 0; i < Game.BossEnemy.EnemiesList.Count;)
                        {
                            if (Bounds.IntersectsWith(Game.BossEnemy.EnemiesList[i].Bounds))
                            {
                                switch (Game.BossEnemy.EnemiesList[i].lives)
                                {
                                    case 1:
                                        Game.BossEnemy.EnemiesList[i].StartExplosion = true;
                                        Game.score += 50;
                                        break;

                                    case 2:
                                        Game.BossEnemy.EnemiesList[i].lives = 1;
                                        Game.score += 60;
                                        break;

                                    case 3:
                                        Game.BossEnemy.EnemiesList[i].lives = 2;
                                        Game.score += 70;
                                        break;

                                    case 4:
                                        Game.BossEnemy.EnemiesList[i].lives = 3;
                                        Game.score += 90;
                                        break;

                                    case 5:
                                        Game.BossEnemy.EnemiesList[i].lives = 4;
                                        Game.score += 100;
                                        break;

                                    case 6:
                                        Game.BossEnemy.EnemiesList[i].lives = 5;
                                        Game.score += 150;
                                        break;

                                    case 7:
                                        Game.BossEnemy.EnemiesList[i].lives = 6;
                                        Game.score += 200;
                                        break;

                                    default:
                                        Game.BossEnemy.EnemiesList[i].NeedsRemoving = true;
                                        break;
                                }
                                StartExplosion = true;
                            }

                            i++;
                        }
                        for (int i = 0; i < Game.BossEnemy.EnemiesList.Count;)
                        {
                            for (int j = 0; j < Game.BossEnemy.EnemiesList[i].BulletList.Count;)
                            {
                                if (Bounds.IntersectsWith(Game.BossEnemy.EnemiesList[i].BulletList[j].Bounds))
                                {
                                    Game.BossEnemy.EnemiesList[i].BulletList[j].NeedsRemoving = true;
                                    NeedsRemoving = true;
                                    Game.score += 1;
                                }
                                j++;
                            }
                            i++;
                        }
                    }

                    CheckBlackhole();
                    
                    Point temp = Location;
                    temp.Y -= 9;
                    Location = temp;                                      
                }
                else if (Type == "Enemy")
                {
                    if (Bounds.IntersectsWith(Game.Ship.Bounds))
                    {
                        Game.Ship.PlayerLives -= 1;
                        NeedsRemoving = true;
                    }

                    CheckBlackhole();

                    Point temp = Location;
                    temp.Y += 7;
                    Location = temp;
                }
                else if (Type == "Boss")
                {
                    if (Bounds.IntersectsWith(Game.Ship.Bounds))
                    {
                        Game.Ship.PlayerLives -= 1;
                        NeedsRemoving = true;
                    }

                    CheckBlackhole();

                    Point temp = Location;
                    temp.Y += 7;
                    if (Location.X < (Game.Ship.PlayerLoc.X + 32))
                    {
                        temp.X += 3;
                    }
                    else if (Location.X > (Game.Ship.PlayerLoc.X + 32))
                    {
                        temp.X -= 3;
                    }

                    Location = temp;
                }
            }

            if (Location.Y > 1000 || Location.Y < 0)
            {
                NeedsRemoving = true;
            }
        }
        public void Draw()
        {
            Bounds = new Rectangle(Location, BulletSize);
            Game._gr.DrawImage(Picture, Location);

            if (Game.ShowBounds)
            {
                Game._gr.DrawRectangle(Pens.Blue, Bounds);
            }

        }

        public void CheckBlackhole()
        {
            if (Game.Ship.b.BlackholeEnabled)
            {
                
            if (Bounds.IntersectsWith(Game.Ship.b.Bounds[0]))
            {
                NeedsRemoving = true;
            }

            if (Bounds.IntersectsWith(Game.Ship.b.Bounds[3]))
            {
                Speed = 10;

                if (Location.X > Game.Ship.b.SpecialLoc.X + 64 && Location.Y > Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = Location;
                    _temp.X -= 1;
                    Location = _temp;
                }
                else if (Location.X > Game.Ship.b.SpecialLoc.X + 64 && Location.Y < Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = Location;
                    _temp.X -= 1;
                    Location = _temp;
                }
                else if (Location.X < Game.Ship.b.SpecialLoc.X + 64 && Location.Y > Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = Location;
                    _temp.X += 1;
                    Location = _temp;
                }
                else if (Location.X < Game.Ship.b.SpecialLoc.X + 64 && Location.Y < Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = Location;
                    _temp.X += 1;
                    Location = _temp;
                }

            }

            if (Bounds.IntersectsWith(Game.Ship.b.Bounds[2]))
            {
                Speed = 11;

                if (Location.X > Game.Ship.b.SpecialLoc.X + 64 && Location.Y > Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = Location;
                    _temp.X -= 2;
                    Location = _temp;
                }
                else if (Location.X > Game.Ship.b.SpecialLoc.X + 64 && Location.Y < Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = Location;
                    _temp.X -= 2;
                    Location = _temp;
                }
                else if (Location.X < Game.Ship.b.SpecialLoc.X + 64 && Location.Y > Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = Location;
                    _temp.X += 2;
                    Location = _temp;
                }
                else if (Location.X < Game.Ship.b.SpecialLoc.X + 64 && Location.Y < Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = Location;
                    _temp.X += 2;
                    Location = _temp;
                }
            }

            if (Bounds.IntersectsWith(Game.Ship.b.Bounds[1]))
            {
                Speed = 12;

                if (Location.X > Game.Ship.b.SpecialLoc.X + 64 && Location.Y > Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = Location;
                    _temp.X -= 3;
                    Location = _temp;
                }
                else if (Location.X > Game.Ship.b.SpecialLoc.X + 64 && Location.Y < Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = Location;
                    _temp.X -= 3;
                    Location = _temp;
                }
                else if (Location.X < Game.Ship.b.SpecialLoc.X + 64 && Location.Y > Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = Location;
                    _temp.X += 3;
                    Location = _temp;
                }
                else if (Location.X < Game.Ship.b.SpecialLoc.X + 64 && Location.Y < Game.Ship.b.SpecialLoc.Y + 64)
                {
                    Point _temp = Location;
                    _temp.X += 3;
                    Location = _temp;
                }
            }

            if (!Bounds.IntersectsWith(Game.Ship.b.Bounds[1]) && !Bounds.IntersectsWith(Game.Ship.b.Bounds[2]) &&
                !Bounds.IntersectsWith(Game.Ship.b.Bounds[3]))
            {
                Speed = 9;
            }
            }

        }

        void MakeEnemyWhite(Enemy E)
        {
            switch (E.Rarity)
            {
                case 1:
                    E.EnemyPic = Properties.Resources.Enemy_1_White;
                    E.EnemyPic .MakeTransparent(Color.Fuchsia);
                    E.WhiteOn = true;
                    E.WhiteFrame = 5;
                    break;

                case 2:
                    E.EnemyPic = Properties.Resources.Enemy_1_White;
                    E.EnemyPic.MakeTransparent(Color.Fuchsia);
                    E.WhiteOn = true;
                    E.WhiteFrame = 5;
                    break;

                case 3:
                    E.EnemyPic = Properties.Resources.Enemy_2_White;
                    E.EnemyPic.MakeTransparent(Color.Fuchsia);
                    E.WhiteOn = true;
                    E.WhiteFrame = 5;
                    break;

                case 4:
                    E.EnemyPic = Properties.Resources.Enemy_3_White;
                    E.EnemyPic.MakeTransparent(Color.Fuchsia);
                    E.WhiteOn = true;
                    E.WhiteFrame = 5;
                    break;

                case 5:
                    E.EnemyPic = Properties.Resources.Enemy_4_White;
                    E.EnemyPic.MakeTransparent(Color.Fuchsia);
                    E.WhiteOn = true;
                    E.WhiteFrame = 5;
                    break;

                case 6:
                    E.EnemyPic = Properties.Resources.Enemy_5_White;
                    E.EnemyPic.MakeTransparent(Color.Fuchsia);
                    E.WhiteOn = true;
                    E.WhiteFrame = 5;
                    break;

                case 7:
                    E.EnemyPic = Properties.Resources.Enemy_6_White;
                    E.EnemyPic.MakeTransparent(Color.Fuchsia);
                    E.WhiteOn = true;
                    E.WhiteFrame = 5;
                    break;
            }
        }
    }
}