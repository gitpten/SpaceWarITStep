using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWar
{
    internal abstract class Sprite
    {
        public Game Game { get; set; }
        public int SpeedX { get; set; }
        public int SpeedY { get; set; }
        public PictureBox Pb { get; set; }

        public virtual void Move()
        {
            Pb.Left += SpeedX;
            Pb.Top += SpeedY;
        }

        protected Sprite(Game game)
        {
            Game = game;            
            Pb = new PictureBox();
            Game.Container.Controls.Add(Pb);
            Pb.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public abstract void Collide(Ship ship);

        public bool IsCollide(Sprite another)
        {
            Rectangle r1 = new Rectangle(Pb.Location, Pb.Size);
            Rectangle r2 = new Rectangle(another.Pb.Location, another.Pb.Size);
            return r1.IntersectsWith(r2);
        }
    }
}
