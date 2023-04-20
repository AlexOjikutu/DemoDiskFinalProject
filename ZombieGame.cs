using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using ZombieGame;

namespace DemoDisk
{
    public partial class ZombieGame : Form
    {
        // Background music
        WindowsMediaPlayer Player = new WindowsMediaPlayer();



        // Game Veriables
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int zombieSpeed = 3;
        int score;
        Random randNum = new Random();

        List<PictureBox> zombiesList = new List<PictureBox>();
        public ZombieGame()
        {
            InitializeComponent();
            Player.URL = "Zombie Shooter Soundtrack - Action 1_2.mp3";
            RestartGame();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                gameOver = true;
                player.Image = Image.FromFile("dead.png");
                GameTimer.Stop();
            }

            txtAmmo.Text = "Ammo:" + ammo;
            player.Text = "Kills" + score;

            if (goLeft == true && player.Left >0)
            {
                player.Left -= speed;
            }

            if (goRight == true &&player.Left+ player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if (goUp == true && player.Top >45)
            {
                player.Top -= speed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Text == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }

                if (x is PictureBox && (string)x.Text == "zombies")
                {
                    if (x.Left > player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image =Image.FromFile("zleft.png");
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Image.FromFile("zright.png");
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Image.FromFile("zup.png");
                    }

                    if (x.Top < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Image.FromFile("zdown.png");
                    }

                    foreach (Control j in this.Controls)
                    {
                        if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                        {
                            if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++;
                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                zombiesList.Remove(((PictureBox)x));
                                MakeZombies();
                            }
                        }


                    }

                }

            }
        }
        // player can go up and down using this function
        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            //Condition statement

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Image.FromFile("left.png");
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Image.FromFile("right.png");
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Image.FromFile("up.png");
            }


            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Image.FromFile("down.png");

            }

        }
        // all this i are difoult set up in false  because it's private 
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;

            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;

            }

            if (e.KeyCode == Keys.Up)
            {
                goLeft = false;

            }


            if (e.KeyCode == Keys.Down)
            {
                goLeft = false;

            }

            if (e.KeyCode == Keys.Space && ammo > 0)
            {
                ammo--;
                ShootBullet(facing);
                if (ammo < 1)
                {
                    DropAmmo();
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player.controls.play();

        }

        // This controles the bullet / it's give the player the ability to shoolt by direction
        public void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width/2);
            shootBullet.bulletTop = player.Top + (player.Width / 2);
            shootBullet.MakeBullet(this);

        }
        public void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Image.FromFile("zdown.png");
            zombie.Left = randNum.Next(0, 900);
            zombie.Top = randNum.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();


        }

        // when we the player will be out of bullets/ will drop the ammo
        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Image.FromFile("ammo_Image.png");
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();
        }



        // after the game is done this function will restart the game from the begining
        public void RestartGame()
        {
            player.Image = Image.FromFile("up.png");
            foreach (PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }
            zombiesList.Clear();

            for (int i = 0; i <3; i++)
            {
                MakeZombies();
            }
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;

            GameTimer.Start();
        }
    }
}
