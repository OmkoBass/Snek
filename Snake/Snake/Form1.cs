using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        List<Snek> snake = new List<Snek>();

        void generateSnek(PaintEventArgs e)
        {
            Snek s = new Snek(150, 150);
            snake.Add(s);
            e.Graphics.FillRectangle(Brushes.Green, snake[snake.Count() - 1].X, snake[snake.Count() - 1].Y, 25, 25);
        }

        void generateFood(PaintEventArgs e)
        {
            Random r = new Random();
            int x = r.Next(0, 820);
            int y = r.Next(0, 460);
            e.Graphics.FillEllipse(Brushes.Red, x, y, 25, 25);
        }

        public Form1()
        {
            InitializeComponent();
            moveTimer.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            generateSnek(e);
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < snake.Count(); i++)
            {
                snake[i].X += 10;
                snake[i].Y += 10;
            }

            Invalidate();
        }
    }
}
