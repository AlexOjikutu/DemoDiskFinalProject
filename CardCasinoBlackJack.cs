using CardCasino;
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
    public partial class CardCasinoBlackJack : Form
    {
       
        private Deck deck1; // use anywhere        
        public CardCasinoBlackJack()
        {
            InitializeComponent();
        }

        private void CardCasino_Load(object sender, EventArgs e) // initializes the deck and shuffles hit and allows hit nd stand button to work
        {
            deck1 = new Deck();
            deck1.Shuffle();
            HitBtn.Enabled = false;
            Standbtn.Enabled = false;
        }

        int playertotal = 0; // init both sides totals to make reseting easier
        int dealertotal = 0;
        int Bet;
        int Bal = 100;

        private void DealButtonTest_Click_1(object sender, EventArgs e) //ignore this was for testing
        {
            Card card = deck1.Deal();
            Image img = Image.FromFile($"Cards/{card.Rank}_of_{card.Suit}.png");
            DealerCard1.Image = img;
            PlayerCard1.Text = ("Your card is the "+ card.Rank +" of "+ card.Suit + " Value is: "+ card.Value);



        }

        private void CardDisplay_Click(object sender, EventArgs e)
        {

        }

        private void CasinoStart_Click(object sender, EventArgs e)
        {
            //starts game and initializes everything
            PlayerCard1txt.Visible= true;
            PlayerCard2txt.Visible= true;
            DealerCard1txt.Visible= true;
            DealerCard2txt.Visible= true;
            CasinoStart.Enabled = false;
            HitBtn.Enabled = true;
            Standbtn.Enabled = true;

            //creates a card I use this same format for every card visible
            Card PC1 = deck1.Deal();
            Image PC1img = Image.FromFile($"Cards/{PC1.Rank}_of_{PC1.Suit}.png");
            PlayerCard1.Image = PC1img;
            PlayerCard1txt.Text = (PC1.Rank +" of "+ PC1.Suit);

            Card PC2 = deck1.Deal();
            Image PC2img = Image.FromFile($"Cards/{PC2.Rank}_of_{PC2.Suit}.png");
            PlayerCard2.Image = PC2img;
            PlayerCard2txt.Text = (PC2.Rank +" of "+ PC2.Suit);

            playertotal = PC1.Value + PC2.Value;
            PlayerCardVal.Text = ("Value: "+ playertotal);

            Card DC1 = deck1.Deal();
            Image DC1img = Image.FromFile($"Cards/{DC1.Rank}_of_{DC1.Suit}.png");
            DealerCard1.Image = DC1img;
            DealerCard1txt.Text = (DC1.Rank +" of "+ DC1.Suit);

            dealertotal = DC1.Value;
            DealerCardValtxt.Text = ("Value: "+ dealertotal);
        }

        private void HitBtn_Click(object sender, EventArgs e)
        {
            Betbtn.Enabled = false;
            if (PlayerHit1.Visible == false) //hits and this checks if a hit has been done before
            {
                PlayerHit1.Visible = true;
                Card PC3 = deck1.Deal();
                Image PC3img = Image.FromFile($"Cards/{PC3.Rank}_of_{PC3.Suit}.png");
                PlayerHit1.Image = PC3img;
                PlayerHit1txt.Text = (PC3.Rank +" of "+ PC3.Suit);

                playertotal = playertotal + PC3.Value;
                if (playertotal > 21)
                {
                    PlayerCardVal.Text = ("BUSTED");
                    playertotal = 0;
                    Winnertxt.Text = ("BUST Dealer Wins!");
                    Bal = Bal - Bet;
                    Baltxt.Text = ($"Balance: {Bal}");
                }
                else { PlayerCardVal.Text = ("Value: "+ playertotal); }


            }
            else if (PlayerHit2.Visible == false) //if the player has already hit this function is run instead
            {
                PlayerHit2.Visible = true;
                Card PC4 = deck1.Deal();
                Image PC4img = Image.FromFile($"Cards/{PC4.Rank}_of_{PC4.Suit}.png");
                PlayerHit2.Image = PC4img;
                PlayerHit2txt.Text = (PC4.Rank +" of "+ PC4.Suit);

                playertotal = playertotal + PC4.Value;
                if (playertotal > 21)
                {
                    PlayerCardVal.Text = ("BUSTED");
                    playertotal = 0;
                    Winnertxt.Text = ("BUST Dealer Wins!");
                    Bal = Bal - Bet;
                    Baltxt.Text = ($"Balance: {Bal}");

                }
                else { PlayerCardVal.Text = ("Value: "+ playertotal); }
            }
        }
        private void WinCondition() //decides who wins and displays this
        {

            if (playertotal > dealertotal)
            {
                Winnertxt.Text = ("Player Wins!");
                Bal = Bal + Bet;
                Baltxt.Text = ($"Balance: {Bal}");

            }
            else if (playertotal < dealertotal)
            {
                Winnertxt.Text = ("Dealer Wins!");
                Bal = Bal - Bet;
                Baltxt.Text = ($"Balance: {Bal}");

            }
            else if (playertotal == dealertotal)
            {
                Winnertxt.Text = ("TIE");
            }
            else
            {
                Winnertxt.Text = ("Unkown Error");
            }
            if (Bal <= 0)
            {
                Winnertxt.Text = ("No Money!");
                RestartBtn.Enabled = false;


            }
        }
        private void GameEnd() //exits the code
        {
            Application.Restart();
        }



        private void Standbtn_Click(object sender, EventArgs e) //ends game and choses winner and also dlips over dealer cards
        {
            HitBtn.Enabled = false;
            Standbtn.Enabled = false;
            Card DC2 = deck1.Deal();
            Image DC2img = Image.FromFile($"Cards/{DC2.Rank}_of_{DC2.Suit}.png");
            DealerCard2.Image = DC2img;
            DealerCard2txt.Text = (DC2.Rank +" of "+ DC2.Suit);

            dealertotal = dealertotal + DC2.Value;
            DealerCardValtxt.Text = ("Value: "+dealertotal);
            if(dealertotal > 21)
            {
                DealerCardValtxt.Text = ("BUSTED");
                Bal = Bal - Bet;
                Baltxt.Text = ($"Balance: {Bal}");
                dealertotal = 0;
            }
            if(dealertotal < 12)
            {
                DealerCard3.Visible = true;
                Card DC3 = deck1.Deal();
                Image DC3img = Image.FromFile($"Cards/{DC3.Rank}_of_{DC3.Suit}.png");
                DealerCard3.Image = DC3img;
                DealerCard3txt.Text = (DC3.Rank +" of "+ DC3.Suit);

                dealertotal = dealertotal + DC3.Value;
                DealerCardValtxt.Text = ("Value: "+dealertotal);
            }

            WinCondition();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
          
        }


        private void RestartBtn_Click(object sender, EventArgs e) //inits a reset
        {
            Betbtn.Enabled = true;
            Bettxtbox.Clear();
            HitBtn.Enabled= true;
            Standbtn.Enabled= true;
            deck1.Shuffle();
            PlayerCard1.Image = Image.FromFile("Cards/Flipped_Over.png");
            PlayerCard2.Image = Image.FromFile("Cards/Flipped_Over.png");
            DealerCard1.Image = Image.FromFile("Cards/Flipped_Over.png");
            DealerCard2.Image = Image.FromFile("Cards/Flipped_Over.png");
            PlayerHit1.Visible = false;
            PlayerHit2.Visible = false;
            CasinoStart.Enabled= true;
            PlayerCard1txt.Visible= false;
            PlayerCard2txt.Visible= false;
            DealerCard1txt.Visible= false;
            DealerCard2txt.Visible= false;
            DealerCard3.Visible= false;
            DealerCard3txt.Visible= false;
            PlayerHit1txt.Visible = false;
            PlayerHit2txt.Visible = false;
            PlayerCardVal.Text = ("Value: ");
            DealerCardValtxt.Text = ("Value: ");
            Winnertxt.Text = ("");

            


        
        }

        private void BlackJackRulesbtn_Click(object sender, EventArgs e) //displays rule tab
        {
            MessageBox.Show("How to play: In Black Jack you are given a starting hand of two cards and your goal is to get as close to 21 as possible without going over. When the game starts you get to see your 2 cards and decide if you want to Hit(get a new card) or Stand(Keep your hand and see game results). In Black Jack the card values are equal to the number on the card and face cards are worth 10 and Ace is worth 11. The Dealer starts with 1 face up card and once you stand there second card gets flipped and if there value is less then 12 the dealer automatically will take a Hit. Whoever has the highest value wins and if its equal there is a tie resulting in no winner");
        }

        private void Betbtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(Bettxtbox.Text) > Bal)
            {
                Bettxtbox.Text=("To High");

            }
            else
            {
                string Bettext = Bettxtbox.Text;
                Bet = int.Parse(Bettext);
                Bettxtbox.Clear();
            }
        }

        private void DealerCard3_Click(object sender, EventArgs e)
        {

        }

        private void Bettxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
