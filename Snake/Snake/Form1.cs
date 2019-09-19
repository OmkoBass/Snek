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
                    if(hitWalls() == true /*|| ateMySelf() == true*/) { GameOver(); }
                    if(snek.Direction == Direction.DOWN) { snek.Down(); }
                    else { snek.Up(); }
                    break;
                case Keys.Down:
                    if (hitWalls() == true /*|| ateMySelf() == true*/) { GameOver(); }
                    if (snek.Direction == Direction.UP) { snek.Up(); }
                    else { snek.Down(); }
                    break;
                case Keys.Left:
                    if (hitWalls() == true /*|| ateMySelf() == true*/) { GameOver(); }
                    if (snek.Direction == Direction.RIGHT) { snek.Right(); }
                    else { snek.Left(); }
                    break;
                case Keys.Right:
                    if (hitWalls() == true /*|| ateMySelf() == true*/) { GameOver(); }
                    if (snek.Direction == Direction.LEFT) { snek.Left(); }
                    else { snek.Right(); }
                    break;
            }
            if(Ate() == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"AutismHamza.wav");
                player.Play();
                food.Randomize(); pts += 100;
                score.Text = pts.ToString();
                BodyPart bodypart = new BodyPart();
                snek.snakeBody.Add(bodypart);
            }
        }

        private void GameOver() { GameTimer.Stop(); MessageBox.Show("Game Over!"); Environment.Exit(0); }

        private bool hitWalls()
        {
            if(snek.Y <= 20) { return true; }
            else if(snek.Y >= this.Height) { return true; }
            else if(snek.X <= 0) { return true; }
            else if(snek.X >= this.Width) { return true; }
            else { return false; }
        }

        private bool ateMySelf()
        {
            //TODO:
            return true;
        }

        private bool Ate()
        {
            if(snek.X == food.X && snek.Y == food.Y) { return true; }
            else { return false; }
        }

        public Form1()
        {
            InitializeComponent();
            BodyPart snakeHead = new BodyPart(snek.X, snek.Y);
            snek.snakeBody.Add(snakeHead);
            forma = this;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen granica = new Pen(Color.Black);
            g.DrawLine(granica, 0, 30, this.Width, 30);

            GameTimer.Start();

            snek.Draw(e);
            snek.DrawBody(e);
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