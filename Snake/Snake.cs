using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace Snake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    class Snake
    {
        public Point Position { get; set; } //Head at the same time
        public Direction Direction { get; set; }
        public List<BodyPart> Body { get; set; }

        public Snake(Point Position)
        {
            this.Body = new List<BodyPart>();
            this.Body.Add(new BodyPart());

            this.Direction = Direction.Right;
            this.Position = Position;
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Green, this.Position.X, this.Position.Y, 20, 20);

            for(int i = this.Body.Count() - 1; i > 0; i--)
            {
                this.Body[i].Position = this.Body[i - 1].Position;
                this.Body[i].Draw(g);
            }

            if (this.Body.Count() > 0)
                this.Body[0].Position = this.Position;
        }

        public void Grow() => this.Body.Add(new BodyPart(new Point(this.Position.X + 20, this.Position.Y)));

        public void MoveUp()
        {
            this.Position = new Point(this.Position.X, this.Position.Y - 20);
            this.Direction = Direction.Up;
        }

        public void MoveDown()
        {
            this.Position = new Point(this.Position.X, this.Position.Y + 20);
            this.Direction = Direction.Down;
        }

        public void MoveLeft()
        {
            this.Position = new Point(this.Position.X - 20, this.Position.Y);
            this.Direction = Direction.Left;
        }

        public void MoveRight()
        {
            this.Position = new Point(this.Position.X + 20, this.Position.Y);
            this.Direction = Direction.Right;
        }
    }
}
