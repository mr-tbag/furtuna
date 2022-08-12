namespace Furtuna
{
    public class Game
    {
        public List<Tank> Tanks = new List<Tank>();
        public Base Base = new Base(999);

        public Game()
        {
            Tanks.Add(new Tank(100, 500, 100, 60, 3, 29, 90));
            Tanks.Add(new Tank(100, 700, 100, 50, 5, 29, 50));
        }

        public void Update(float deltaSeconds)
        {
            foreach (var tank in Tanks)
            {
                tank.Move(deltaSeconds);
            }
        }

        public void Render(Graphics g)
        {
            g.Clear(Color.White);
            var brush = new SolidBrush(Color.Green);
            foreach (var tank in Tanks)
            {
                g.FillRectangle(brush, tank.X, tank.Y, tank.Length, tank.Width);
            }
        }

        public void Click(int x, int y)
        {

        }
    }
    public class Tank
    {
        public int X;
        public int Y;
        public int Length;
        public int Width;
        public int Hp;
        public int Damage;
        public int Speed;

        public Tank(int x, int y, int length, int width, int hp, int damage, int speed)
        {
            X = x;
            Y = y;
            Length = length;
            Width = width;
            Hp = hp;
            Damage = damage;
            Speed = speed;
        }

        public void Move(float deltaSeconds)
        {
            X = X + (int)(Speed * deltaSeconds);
        }
    }

    public class Base
    {
        public int X;
        public List<Gun> Guns = new List<Gun>();

        public Base(int x)
        {
            X = x;
            
        }
    }

    public class Gun
    {
        public int Damage;

        public Gun(int damage)
        {
            Damage = damage;
        }
    }


    public class Bullet
    {
        public int Damage;
        public int X;
        public int Y;

        public Bullet(int damage, int x, int y)
        {
            Damage = damage;
            X = x;
            Y = y;
        }

    }
    
    
}