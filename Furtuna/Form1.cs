namespace Furtuna
{
    public partial class Form1 : Form
    {
        //private Tank _tank = new Tank(100,500,50,20,6,29,20);
        private Game _game = new Game();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //var b = new Base(999);
            
            //b.Guns.Add(new Gun(6));
            //b.Guns.Add(new Gun(8));

            //var bullet = new Bullet(6, 100, 1000);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //_tank.Move(0.1f);
            var g = panel1.CreateGraphics();
            //g.Clear(Color.White);
            //var brush = new SolidBrush(Color.Green);
            //g.FillRectangle(brush, _tank.X, _tank.Y, _tank.Length, _tank.Width);
            _game.Update(0.1f);
            _game.Render(g);
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            _game.Click(e.X, e.Y);
        }
    }
}