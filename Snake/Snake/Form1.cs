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
        static Snek snek = new Snek(150, 150);
        

        private void bodyPart()
        {
            
        }

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
                    if (snek.Y >= 420) { GameTimer.Stop(); MessageBox.Show("Game Over!"); Environment.Exit(0); }
                    if (snek.Direction == Direction.UP) { snek.Up(); }
                    else { snek.Down(); }
                    break;
                case Keys.Left:
                    if (snek.X <= 0) { GameTimer.Stop(); MessageBox.Show("Game Over!"); Environment.Exit(0); }
                    if (snek.Direction == Direction.RIGHT) { snek.Right(); }
                    else { snek.Left(); }
                    break;
                case Keys.Right:
                    if (snek.X >= 780) { GameTimer.Stop(); MessageBox.Show("Game Over!"); Environment.Exit(0); }
                    if (snek.Direction == Direction.LEFT) { snek.Left(); }
                    else { snek.Right(); }
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen granica = new Pen(Color.Black);
            g.DrawLine(granica, 0, 40, 820, 40);

            GameTimer.Start();

            snek.Draw(e);

            moveSnek();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            keyMove = e.KeyCode;
            moveSnek();
        }
    }
}
