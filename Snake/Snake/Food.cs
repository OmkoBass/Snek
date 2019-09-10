using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    class Food
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Eaten { get; set; }

        public Food()
        {
            this.X = 460;
            this.Y = 320;
            this.Eaten = false;
        }

        public Food(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
            this.Eaten = false;
        }

        internal void Draw(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, this.X, this.Y, 25, 25);
        }
    }
}
