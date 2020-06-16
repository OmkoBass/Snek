using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class BodyPart
    {
        public Point Position { get; set; }

        public BodyPart()
        {

        }
        public BodyPart(Point Position)
        {
            this.Position = Position;
        }

        public void Draw(Graphics g) => g.FillRectangle(Brushes.Green, this.Position.X, this.Position.Y, 20, 20);
    }
}
