namespace DemoDisk
{
    public partial class DemoDiskMain : Form
    {
        public DemoDiskMain()
        {
            InitializeComponent();
        }

        private void CasinoBtn_Click(object sender, EventArgs e)
        {
            var newform = new CasinoMain();
            newform.Show();
        }

        private void Sam_Click(object sender, EventArgs e)
        {
            ZombieGame Zombie = new ZombieGame();
            Zombie.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var StartScreen = new Start_Screen();
            StartScreen.Show();
        }

        private void Alec_Click(object sender, EventArgs e)
        {
            ConsoleMain consolegames = new ConsoleMain();
            consolegames.Show();
        }

        private void DemoDiskMain_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("70619a9655183.560d7bfb8dc17.jpg");
        }
    }
}