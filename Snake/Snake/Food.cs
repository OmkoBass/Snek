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

        public Food()
        {
            this.X = 200;
            this.Y = 200;
        }

        public Food(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        private Random rand = new Random();

        public void Randomize()
        {
            this.X = rand.Next(1, Form1.forma.Width / 20) * 20;
            this.Y = rand.Next(1, Form1.forma.Height / 20) * 20;
            if(this.Y <= 20) { this.Y = rand.Next(1, Form1.forma.Height / 20) * 20; }
        }

        internal void Draw(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, this.X, this.Y, 20, 20);
        }
    }
}
