using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        Snake snake = new Snake(new Point(80, 0));
        Food food = new Food();

        int score = 0;

        bool IsFoodThere = false;
        bool AteOnce = false;

        Keys keys;
        public Form1()
        {
            InitializeComponent();

            Score.Text = score.ToString();

            GameTimer.Start();
        }

        private void MoveSnake()
        {
            switch (keys)
            {
                case Keys.Right:
                    if (snake.Direction == Direction.Left)
                        snake.MoveLeft();
                    else
                        snake.MoveRight();
                    break;
                case Keys.Left:
                    if (snake.Direction == Direction.Right)
                        snake.MoveRight();
                    else
                        snake.MoveLeft();
                    break;
                case Keys.Up:
                    if (snake.Direction == Direction.Down)
                        snake.MoveDown();
                    else
                        snake.MoveUp();
                    break;
                case Keys.Down:
                    if (snake.Direction == Direction.Up)
                        snake.MoveUp();
                    else
                        snake.MoveDown();
                    break;
            }
            
            if (snake.Position == food.Position)
            {
                snake.Grow();
                score++;
                IsFoodThere = false;
                AteOnce = true;
            }
        }

        private void CheckDead()
        {
            if (snake.Position.X >= 800 || snake.Position.X <= -20 || snake.Position.Y >= 560 || snake.Position.Y <= -20)
                GameOver();

            if(AteOnce)
            {
                foreach (BodyPart b in snake.Body)
                    if (b.Position == snake.Position)
                        GameOver();
            }
        }

        private void GenerateFood()
        {
            if(!IsFoodThere)
            {
                food.Generate();
                IsFoodThere = true;
            }
        }

        private void GameOver()
        {
            GameTimer.Stop();
            MessageBox.Show("Dead!");
            this.Close();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics) {
                g.FillRectangle(Brushes.LightGray, 0, 0, 800, 650);
                snake.Draw(g);
                food.Draw(g);
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            GenerateFood();
            MoveSnake();
            CheckDead();
            Invalidate();
            Update();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            keys = e.KeyCode;
        }
    }
}
