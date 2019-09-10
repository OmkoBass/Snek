using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    class BodyPart
    {
        public int X { get; set; }
        public int Y { get; set; }

        public BodyPart()
        {

        }

        public BodyPart(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        internal void Draw(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Green, this.X, this.Y, 20, 20);
        }
        
    }
}
