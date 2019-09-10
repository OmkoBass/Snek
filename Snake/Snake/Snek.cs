using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    enum Direction { UP, DOWN, LEFT, RIGHT }

    class Snek
    {
        public List<BodyPart> snake = new List<BodyPart>();

        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }

        public Snek(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        internal void Draw(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Green, this.X, this.Y, 20, 20);
        }
        public void Up()
        {
            this.Y -= 20;
            this.Direction = Direction.UP;
        }
        public void Down()
        {
            this.Y += 20;
            this.Direction = Direction.DOWN;
        }
        public void Left()
        {
            this.X -= 20;
            this.Direction = Direction.LEFT;
        }
        public void Right()
        {
            this.X += 20;
            this.Direction = Direction.RIGHT;
        }

    }
}
