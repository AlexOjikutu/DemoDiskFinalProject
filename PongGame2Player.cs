using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDisk
{
    public partial class PongGame2Player : Form
    {

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
        bool player2moveUp;
        bool player2moveDown;
        int rallyCounter;
        int playerCenter;
        int reboundCorrect;
        int spaceHit;


        public PongGame2Player()
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

        private void PongGame_Load(object sender, EventArgs e)
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
                ball.Left = reboundCorrect - 50;
                ballX = -ballX;
                rallyCounter++;
                rallycounterLabel.Text = rallyCounter.ToString();

            }

            // paddle movement
            if (player1moveUp == true && player1.Top > 0) { player1.Top -= 3; }

            if (player1moveDown == true && player1.Top < bounds) { player1.Top += 3; }

            if (player2moveUp == true && player2.Top > 0) { player2.Top -= 3; }

            if (player2moveDown == true && player2.Top < bounds) { player2.Top += 3; }

            if (player1score == 11)
            {
                pongTimer.Stop();
                MessageBox.Show("Player1 Won! Press(E) to play again.\"");
            }

            if (player2score == 11)
            {
                pongTimer.Stop();
                MessageBox.Show("Player2 Won! Press(E) to play again.");
            }

        }

        //checks keys pressed, moves paddles accordingly
        private void PongGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { player2moveUp = true; }
            if (e.KeyCode == Keys.Down) { player2moveDown = true; }
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
            if (e.KeyCode == Keys.P)
            {
                // Form StartScreen = new Start_Screen();
                pongTimer.Stop();
            }
        }

        private void PongGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { player2moveUp = false; }
            if (e.KeyCode == Keys.Down) { player2moveDown = false; }
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
