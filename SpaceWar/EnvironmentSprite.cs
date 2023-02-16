namespace SpaceWar
{
    internal abstract class EnvironmentSprite: Sprite
    {
        private static readonly Random random = new Random();

        public EnvironmentSprite(Game game) : base(game)
        {
        }

        public override void Move()
        {
            base.Move();
            if (Pb.Left < -Pb.Width)
                GoStart();
        }

        public void GoStart()
        {
            Pb.Left = Pb.Parent.Width * 15 / 10;
            Pb.Top = random.Next(Pb.Parent.Height - Pb.Height);
            SpeedX = -random.Next(5, 20);
            int size = random.Next(20, 100);
            Pb.Size = new Size(size, size);
        }

        public abstract override void Collide(Ship ship);
    }
}