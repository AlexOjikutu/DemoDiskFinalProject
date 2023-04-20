using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDisk
{
    public partial class PongGameEZCPU : Form
    {
        int player2movement = 5;
        int ballX = 5;
        int ballY = 5;
        int player1score = 0;
        int player2score = 0;
        int bounds;
        int centerX;
        int centerY;
        //int centerPoint;
        bool player1moveUp;
        bool player1moveDown;
        int reboundCorrect;
        int spaceHit = 0;

        int rallyCounter;
        int playerCenter;
        public PongGameEZCPU()
        {
            InitializeComponent();
            MessageBox.Show("Press (Spacebar) to Start Game");

            bounds = ClientSize.Height - player1.Height; // sets paddle boundary
            bounds = ClientSize.Height - player2.Height;
            centerX = ClientSize.Width / 2; //sets integer value to middle of window on long side
            centerY = ClientSize.Height / 2; //short side
            playerCenter = bounds / 2;
            reboundCorrect = ClientSize.Width - ball.Width;
            ballReset.Interval = 1000;
            ballReset.Tick += pongTimer_Tick;
        }

        private void PongGameEZCPU_Load(object sender, EventArgs e)
        {
            ball.Left = centerX;
            ball.Top = centerY;
            player1.Top = playerCenter;
            player2.Top = playerCenter;
        }

        private void pongTimer_Tick(object sender, EventArgs e)
        {
            // int resetBall = 1;

            // sets the ball in motion diagonally
            ball.Top -= ballY;
            ball.Left -= ballX;

            player2.Top += player2movement;

            if (player2.Top < 0 || player2.Top > bounds) { player2movement = -player2movement; }


            // if the ball goes off to the left, recenters ball, sets it in the opposite direction, and adjusts score
            if (ball.Left < 0)
            {

                ball.Left = centerX;
                ball.Top = centerY;
                player1.Top = playerCenter;
                player2.Top = playerCenter;
                ballY = 5;
                ballX = 5;
                ballX = -ballX;
                player1score++;
                player1scoreLabel.Text = player1score.ToString();
                rallyCounter = 0;
                rallycounterLabel.Text = rallyCounter.ToString();

                pongTimer.Stop();
                ballReset.Start();

            }

            // if the ball goes off to the right
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = centerX;
                ball.Top = centerY;
                player1.Top = playerCenter;
                player2.Top = playerCenter;
                ballX = -ballX;
                player2score++;
                player2scoreLabel.Text = player2score.ToString();
                rallyCounter = 0;
                rallycounterLabel.Text = rallyCounter.ToString();

                pongTimer.Stop();
                ballReset.Start();
            }

            // if top of ball is at the top of the window or the ball goes below the window, the ball will go in the opposite direction
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                ballY = -ballY;

            }

            // if ball intersects with either paddle it sends ball in the other direction
            if (ball.Bounds.IntersectsWith(player1.Bounds))
            {

                // sends ball in opposite direction
                ball.Left = reboundCorrect - 730;
                ballX = -ballX;
                rallyCounter++;
                rallycounterLabel.Text = rallyCounter.ToString();

            }

            if (ball.Bounds.IntersectsWith(player2.Bounds))
            {

                // sends ball in opposite direction
                ball.Left = reboundCorrect - 60;
                ballX = -ballX;
                rallyCounter++;
                rallycounterLabel.Text = rallyCounter.ToString();

            }

            // paddle movement
            if (player1moveUp == true && player1.Top > 0) { player1.Top -= 5; }

            if (player1moveDown == true && player1.Top < bounds) { player1.Top += 5; }

            if (player1score == 11)
            {
                pongTimer.Stop();
                MessageBox.Show("Player1 Won! Press(E) to play again.\"");
            }

            if (player2score == 11)
            {
                pongTimer.Stop();
                MessageBox.Show("CPU Won! Press(E) to play again.");
            }
        }

        private void PongGameEZCPU_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W) { player1moveUp = true; }
            if (e.KeyCode == Keys.S) { player1moveDown = true; }
            if (e.KeyCode == Keys.Space)
            {
                if (spaceHit % 2 == 0) { pongTimer.Enabled = true; }
                else { pongTimer.Enabled = false; }

                spaceHit++;
            }

            if (e.KeyCode == Keys.E)
            {
                this.Close();

            }
            if (e.KeyCode == Keys.M)
            {
                Form StartScreen = new Start_Screen();
                pongTimer.Stop();
            }
        }

        private void PongGameEZCPU_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W) { player1moveUp = false; }
            if (e.KeyCode == Keys.S) { player1moveDown = false; }
        }

        private void ballReset_Tick(object sender, EventArgs e)
        {
            ballReset.Stop();
            pongTimer.Start();
        }
    }
}
