using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    class Score
    {
        private Player player;
        private double normalizedPoints;
        private double points;
        private int gameMode;

        private double normalizePoints()
        {
            double normalizedPoints;
            normalizedPoints = points * (8 - player.ageGroup) * gameMode;
            return normalizedPoints;
        }
    }
}
