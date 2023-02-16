namespace SpaceWar
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
            game = new Game(this);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Update();
            if(game.IsOver)
                timer1.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                game.Ship.GoDown();
            if(e.KeyCode == Keys.Up)
                game.Ship.GoUp();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            game.Ship.Stop();
        }
    }
}