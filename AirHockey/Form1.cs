using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirHockey
{
    public partial class Form1 : Form
    {
        Rectangle puck = new Rectangle(280, 430, 40, 40);
        Rectangle outline = new Rectangle(5, 5, 590, 890);
        Rectangle player1 = new Rectangle(275, 200, 50, 50);
        Rectangle player2 = new Rectangle(275, 650, 50, 50);

        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush goalBrush = new SolidBrush(Color.CornflowerBlue);
        Pen redPen = new Pen(Color.Red, 10);
        Pen bluePen = new Pen(Color.Blue, 10);
        Pen blackPen = new Pen(Color.Black, 10);
        Pen goalPen = new Pen(Color.CornflowerBlue, 10);    

        int player1Score = 0;
        int player2Score = 0;

        int playerSpeed = 10;
        int puckXSpeed = 0;
        int puckYSpeed = 0;

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftDown = false;
        bool rightDown = false;


        int tickCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawArc(redPen, 175, 325, 250, 250, 0, 360);
            e.Graphics.DrawLine(redPen, 0, 450, 600, 450);
            e.Graphics.DrawLine(bluePen, 0, 222, 600, 222);
            e.Graphics.DrawLine(bluePen, 0, 678, 600, 678);
            e.Graphics.DrawRectangle(blackPen, outline);
            e.Graphics.DrawLine(goalPen, 200, 5, 400, 5);
            e.Graphics.DrawLine(goalPen, 200, 895, 400, 895);
            e.Graphics.FillPie(goalBrush, 200, -90, 200, 200, 0, 180);
            e.Graphics.FillPie(goalBrush, 200, 810, 200, 200, 180, 360);
            e.Graphics.FillRectangle(blackBrush, player1);
            e.Graphics.FillRectangle(blackBrush, player2);
            e.Graphics.FillEllipse(blackBrush, puck);

            player1ScoreLabel.Text = $"{player1Score}";
            player2ScoreLabel.Text = $"{player2Score}";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            puck.Y += puckYSpeed;
            puck.X += puckXSpeed;

            //Player 1 Movement
            if (wDown == true && player1.Y > 10)
            {
                player1.Y -= playerSpeed;
            }

            if (sDown == true && player1.Y < 445 - player1.Height)
            {
                player1.Y += playerSpeed;
            }

            if (aDown == true && player1.X > 10)
            {
                player1.X -= playerSpeed;
            }

            if (dDown == true && player1.X < this.Width - player1.Width - 10)
            {
                player1.X += playerSpeed;
            }

            //Player 2 Movement
            if (upArrowDown == true && player2.Y > 455)
            {
                player2.Y -= playerSpeed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height - 10)
            {
                player2.Y += playerSpeed;
            }

            if (leftDown == true && player2.X > 10)
            {
                player2.X -= playerSpeed;
            }

            if (rightDown == true && player2.X < this.Width - player2.Width - 10)
            {
                player2.X += playerSpeed;
            }

            //Check Puck Collision and Change Direction
            if (puck.Y < 10)
            {
                puck.Y = 10;
                puckYSpeed = -puckYSpeed;

                if (puck.X >= 200 && puck.X + puck.Width <= 400)
                {
                    player2Score++;

                    puck.X = 280;
                    puck.Y = 430;
                    puckXSpeed = 0;
                    puckYSpeed = 0;

                    player1.Y = 200;
                    player1.X = 275;
                    player2.Y = 650;
                    player2.X = 275;
                }
            }

            if (puck.Y > this.Height - puck.Height - 10)
            {
                puck.Y = this.Height - puck.Height - 10;
                puckYSpeed = -puckYSpeed;

                if (puck.X >= 200 && puck.X + puck.Width <= 400)
                {
                    player1Score++;

                    puck.X = 280;
                    puck.Y = 430;
                    puckXSpeed = 0;
                    puckYSpeed = 0;

                    player1.Y = 200;
                    player1.X = 275;
                    player2.Y = 650;
                    player2.X = 275;
                }
            }

            //Check Puck Wall Collision and Change Direction
            if (puck.X + puck.Width > 590)
            {
                puck.X = 590 - puck.Width;
                puckXSpeed *= -1;
            }
            if (puck.X < 10)
            {
                puck.X = 10;
                puckXSpeed *= -1;
            }

            //Check Puck Player Collision and Change Direction
            if (player1.IntersectsWith(puck))
            {
                //Puck to the Left
                if (puck.X <= player1.X && puck.Y <= player1.Y + player1.Height / 2 && puck.Y >= player1.Y - player1.Height / 2)
                {
                    puck.X -= puck.Width;
                    puckXSpeed = -10;
                }
                //Puck to the Top
                if (puck.Y <= player1.Y && puck.X <= player1.X + player1.Width / 2 && puck.X >= player1.X - player1.Width / 2)
                {
                    puck.Y -= puck.Height;
                    puckYSpeed = -10;
                }
                //Puck to the Right
                if (puck.X >= player1.X && puck.Y <= player1.Y + player1.Height / 2 && puck.Y >= player1.Y - player1.Height / 2)
                {
                    puck.X -= puck.Width;
                    puckXSpeed = 10;
                }
                //Puck to the Bottom
                if (puck.Y >= player1.Y && puck.X <= player1.X + player1.Width / 2 && puck.X >= player1.X - player1.Width / 2)
                {
                    puck.Y += puck.Height;
                    puckYSpeed = 10;
                }
            }


            if (player2.IntersectsWith(puck))
            {
                //Puck to the Left
                if (puck.X <= player2.X && puck.Y <= player2.Y + player2.Height / 2 && puck.Y >= player2.Y - player2.Height / 2)
                {
                    puck.X -= puck.Width;
                    puckXSpeed = -10;
                }
                //Puck to the Top
                if (puck.Y <= player2.Y && puck.X <= player2.X + player2.Width / 2 && puck.X >= player2.X - player2.Width / 2)
                {
                    puck.Y -= puck.Height;
                    puckYSpeed = -10;
                }
                //Puck to the Right
                if (puck.X >= player2.X && puck.Y <= player2.Y + player2.Height / 2 && puck.Y >= player2.Y - player2.Height / 2)
                {
                    puck.X -= puck.Width;
                    puckXSpeed = 10;
                }
                //Puck to the Bottom
                if (puck.Y >= player2.Y && puck.X <= player2.X + player2.Width / 2 && puck.X >= player2.X - player2.Width / 2)
                {
                    puck.Y += puck.Height;
                    puckYSpeed = 10;
                }
            }


            if (tickCounter % 10 == 0)
            {
                if (puckXSpeed > 0)
                {
                    puckXSpeed -= 1;
                }
                if (puckYSpeed > 0)
                {
                    puckYSpeed -= 1;
                }
            }

            tickCounter++;

            if (player1Score == 5)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player  1  Wins!";
            }
            else if (player2Score == 3)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player  2  Wins!";
            }

            Refresh();

        }
    }
}


