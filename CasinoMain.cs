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
    public partial class CasinoMain : Form
    {
        public CasinoMain()
        {
            InitializeComponent();
        }

        private void BlackJackBtn_Click(object sender, EventArgs e)
        {
            var newform = new CardCasinoBlackJack();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new _3CardPoker();
            newform.Show();
        }
    }
}
