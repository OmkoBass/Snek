using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {
        public Point Position { get; set; }

        public Food()
        {
            
        }

        public void Generate()
        {
            Random rand = new Random();
            this.Position = (new Point(rand.Next(0, 800) / 20 * 20, rand.Next(0, 560) / 20 * 20));
        }

        public void Draw(Graphics g) => g.FillRectangle(Brushes.Red, this.Position.X, this.Position.Y, 20, 20);
    }
}
