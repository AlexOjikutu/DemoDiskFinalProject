using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DemoDisk
{
    public partial class ConsoleMain : Form
    {
        public ConsoleMain()
        {
            InitializeComponent();
        }

        private void TTTButton_Click(object sender, EventArgs e)
        {
            string TTT = @"TTT.ITFIN.exe";
            Process.Start(TTT);

        }

        private void Hangmanbtn_Click(object sender, EventArgs e)
        {
            string Hangman = @"hangman.exe";
            Process.Start(Hangman);
        }

        private void Mathbtn_Click(object sender, EventArgs e)
        {
            string math = @"SPEEDMATH-GAM110-008";
            Process.Start(math);
        }

        private void Lockbtn_Click(object sender, EventArgs e)
        {
            string lockpick = @"Lockpicking-IT145FIN-001";
            Process.Start(lockpick);

        }

        private void Mazebtn_Click(object sender, EventArgs e)
        {

        }

        private void MazeGamebtn_Click(object sender, EventArgs e)
        {
            string maze = @"ProcedureMazeGame-GAM110-015";
            Process.Start(maze);
        }

        private void ConsoleMain_Load(object sender, EventArgs e)
        {

        }
    }
}
