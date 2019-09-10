using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        Keys keyMove;
        Snek snek = new Snek(200, 200);
        Food food = new Food();
        int pts = 0;

        public static Form1 forma;

        private void moveSnek()
        {
            switch (keyMove)
            {
                case Keys.Up:
                    if(snek.Y <= 40) { GameTimer.Stop(); MessageBox.Show("Game Over!"); Environment.Exit(0); }
                    if(snek.Direction == Direction.DOWN) { snek.Down(); }
                    else { snek.Up(); }
                    break;
                case Keys.Down:
                    if (snek.Y >= this.Height) { GameTimer.Stop(); MessageBox.Show("Game Over!"); Environment.Exit(0); }
                    if (snek.Direction == Direction.UP) { snek.Up(); }
                    else { snek.Down(); }
                    break;
                case Keys.Left:
                    if (snek.X <= 0) { GameTimer.Stop(); MessageBox.Show("Game Over!"); Environment.Exit(0); }
                    if (snek.Direction == Direction.RIGHT) { snek.Right(); }
                    else { snek.Left(); }
                    break;
                case Keys.Right:
                    if (snek.X >= this.Width) { GameTimer.Stop(); MessageBox.Show("Game Over!"); Environment.Exit(0); }
                    if (snek.Direction == Direction.LEFT) { snek.Left(); }
                    else { snek.Right(); }
                    break;
            }
            if(Ate() == true) { food.Randomize(); pts += 100; score.Text = pts.ToString(); }
        }

        private bool Ate()
        {
            if(snek.X == food.X && snek.Y == food.Y) { return true; }
            else { return false; }
        }

        public Form1()
        {
            InitializeComponent();
            forma = this;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen granica = new Pen(Color.Black);
            g.DrawLine(granica, 0, 40, this.Width, 40);

            GameTimer.Start();

            snek.Draw(e);
            food.Draw(e);
            moveSnek();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            moveSnek();

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            keyMove = e.KeyCode;
        }
    }
}