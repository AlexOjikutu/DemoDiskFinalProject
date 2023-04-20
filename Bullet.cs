using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ZombieGame
{
    internal class Bullet
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;


        private int speed = 50;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();
        

        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.OrangeRed;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;

            form.Controls.Add(bullet);

            bulletTimer.Interval = speed;
            bulletTimer.Tick+= new EventHandler(BulletTimerEvent);
            bulletTimer.Start();

        }
        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                bullet.Left -= speed;
            }
            if (direction == "right")
            {
                bullet.Left += speed;
            }

            if (direction == "up")
            {
                bullet.Top -= speed;
            }
            if (direction =="down")
            {
                bullet.Top += speed;
            }


            if (bullet.Left <10 ||bullet.Left > 860 || bullet.Top <10 || bullet.Top > 600)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bulletTimer = null;
                bullet = null;

            }



        }
    }
}
