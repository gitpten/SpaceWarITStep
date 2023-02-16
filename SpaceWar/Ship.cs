using SpaceWar.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWar
{
    internal class Ship : Sprite
    { 
        public Ship(Game game) : base(game)
        {
            Pb.Image = Resources.ufo;
            Pb.Left = game.Container.Width / 5;
            Pb.Top = game.Container.Height / 2;
            Pb.Size = new Size(200, 100);            
        }

        public void GoUp()
        {
            SpeedY = -20;
        }

        public void GoDown()
        {
            SpeedY = 20;
        }

        public void Stop()
        {
            SpeedY = 0;
        }

        public override void Collide(Ship ship)
        {
        }
    }
}
