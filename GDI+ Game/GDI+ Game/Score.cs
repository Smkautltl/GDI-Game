using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Game
{
    public class Score
    {
        private int bossedKilled;

        public int score { get; set; }
        public string Name { get; set; }
        public int EnemiesKilled { get; set; }
        public int BossesKilled { get; set; }

        public Score()
        {
            score = 0;
            Name = "";
            EnemiesKilled = 0;
            BossesKilled = 0;
        }

        public Score(int _score, int enemiesKilled, int bossedKilled)
        {
            score = _score;
            EnemiesKilled = enemiesKilled;
            BossesKilled = bossedKilled;
        }
    }
}
