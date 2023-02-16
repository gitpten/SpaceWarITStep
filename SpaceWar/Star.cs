using SpaceWar.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWar
{
    internal class Star : EnvironmentSprite
    {
        public Star(Game game) : base(game)
        {
            Pb.Image = Resources.star;
            GoStart();
        }

        public override void Collide(Ship ship)
        {
            GoStart();
            Game.ScoreUp(10);
        }

    }
}
