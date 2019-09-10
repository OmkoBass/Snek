﻿using System;
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
        public List<BodyPart> snakeBody = new List<BodyPart>();

        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }

        public Snek(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
            this.Direction = Direction.RIGHT;
        }

        internal void Draw(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Green, this.X, this.Y, 20, 20);
        }

        internal void DrawBody(PaintEventArgs e)
        {
            snakeBody[0].X = X;
            snakeBody[0].Y = Y;
            for (int i = snakeBody.Count() - 1; i >= 0; i--)
            {
                if(i == 0) { continue; }
                snakeBody[i].X = snakeBody[i - 1].X;
                snakeBody[i].Y = snakeBody[i - 1].Y;
                snakeBody[i].Draw(e);
            }
        }

        public void Up()
        {
            this.Y -= 10;
            this.Direction = Direction.UP;
        }
        public void Down()
        {
            this.Y += 10;
            this.Direction = Direction.DOWN;
        }
        public void Left()
        {
            this.X -= 10;
            this.Direction = Direction.LEFT;
        }
        public void Right()
        {
            this.X += 10;
            this.Direction = Direction.RIGHT;
        }

    }
}
