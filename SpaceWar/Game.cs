using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWar
{
    internal class Game
    {
        public List<Sprite> Sprites { get; set; }
        public Ship Ship { get; set; }
        public int Score { get; set; }
        public bool IsOver { get; set; }
        public Control Container { get; set; }

        public Game(Control container)
        {
            Container = container;
            Sprites = new List<Sprite>();
            Ship = new Ship(this);
            Sprites.Add(Ship);
            for (int i = 0; i < 10; i++)
            {
                Sprites.Add(new Star(this));
            }
            for (int i = 0; i < 5; i++)
            {
                Sprites.Add(new Rock(this));
            }
        }

        public void ScoreUp(int points)
        {
            Score += points;
        }

        public void Update()
        {
            foreach (var sprite in Sprites)
            {
                sprite.Move();
                if (sprite.IsCollide(Ship))
                    sprite.Collide(Ship);
            }
        }
    }
}
