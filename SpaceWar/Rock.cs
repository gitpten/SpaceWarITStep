using SpaceWar.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWar
{
    internal class Rock: EnvironmentSprite
    {
        public Rock(Game game) : base(game)
        {
            Pb.Image = Resources.Rock;
            GoStart();
        }

        public override void Collide(Ship ship)
        {
            GoStart();
            Game.IsOver = true;
        }
    }
}
