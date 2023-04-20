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
    public partial class Start_Screen : Form
    {
        public Start_Screen()
        {
            InitializeComponent();
        }


        private void Start_Screen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D2)
            {
                Form Game = new PongGame2Player();
                Game.Show();
            }
            if (e.KeyCode == Keys.D1)
            {
                Form GameSingleAi = new PongGamevsCPU();
                GameSingleAi.Show();
            }
            if (e.KeyCode == Keys.E)
            {
                Form GameSingle = new PongGameEZCPU();
                GameSingle.Show();
            }
        }

        private void Start_Screen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
