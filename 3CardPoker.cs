
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
    public partial class _3CardPoker : Form
    {
        private Deck Deck2;

        int DC1Suit, DC2Suit, DC3Suit;
        int PC1Val, PC2Val, PC3Val, DC1Val, DC2Val, DC3Val;
        string playerhand = ("nul");
        string dealerhand = ("null");
        string Ppair;
        string Dpair;
        int PHandVal;
        int DHandVal;
        int PHigh;
        int DHigh;
        int Bal = 100;
        int Bet;
        

        private void ResetbtnEnd_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void DealerCard3_Click(object sender, EventArgs e)
        {

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

        
        public _3CardPoker()
        {
            InitializeComponent();
        }

        private void _3CardPoker_Load(object sender, EventArgs e)
        {
            Deck2 = new Deck();
            Deck2.Shuffle();
        }

        bool IsInSequence(int PC1Val, int PC2Val, int PC3Val)
        {
            int[] arr = { PC1Val, PC2Val, PC3Val };
            Array.Sort(arr);
            return (arr[0] + 1 == arr[1] && arr[1] + 1 == arr[2]);
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            button1.Enabled= true;
            Startbtn.Enabled = false;
            Card PC1 = Deck2.Deal();
            Image PC1img = Image.FromFile($"Cards/{PC1.Rank}_of_{PC1.Suit}.png");
            PlayerCard1.Image = PC1img;
            PlayerCard1txt.Text = (PC1.Rank +" of "+ PC1.Suit);

            Card PC2 = Deck2.Deal();
            Image PC2img = Image.FromFile($"Cards/{PC2.Rank}_of_{PC2.Suit}.png");
            PlayerCard2.Image = PC2img;
            PlayerCard2txt.Text = (PC2.Rank +" of "+ PC2.Suit);

            Card PC3 = Deck2.Deal();
            Image PC3img = Image.FromFile($"Cards/{PC3.Rank}_of_{PC3.Suit}.png");
            PlayerCard3.Image = PC3img;
            PlayerCard3txt.Text = (PC3.Rank +" of "+ PC3.Suit);

            ////////////// identifies hand
            if (PC1.Rank == "2") { PC1Val = 2; }
            if (PC1.Rank == "3") { PC1Val = 3; }
            if (PC1.Rank == "4") { PC1Val = 4; }
            if (PC1.Rank == "5") { PC1Val = 5; }
            if (PC1.Rank == "6") { PC1Val = 6; }
            if (PC1.Rank == "7") { PC1Val = 7; }
            if (PC1.Rank == "8") { PC1Val = 8; }
            if (PC1.Rank == "9") { PC1Val = 9; }
            if (PC1.Rank == "10") { PC1Val = 10; }
            if (PC1.Rank == "Jack") { PC1Val = 11; }
            if (PC1.Rank == "Queen") { PC1Val = 12; }
            if (PC1.Rank == "King") { PC1Val = 13; }
            if (PC1.Rank == "Ace") { PC1Val = 14; }

            if (PC2.Rank == "2") { PC2Val = 2; }
            if (PC2.Rank == "3") { PC2Val = 3; }
            if (PC2.Rank == "4") { PC2Val = 4; }
            if (PC2.Rank == "5") { PC2Val = 5; }
            if (PC2.Rank == "6") { PC2Val = 6; }
            if (PC2.Rank == "7") { PC2Val = 7; }
            if (PC2.Rank == "8") { PC2Val = 8; }
            if (PC2.Rank == "9") { PC2Val = 9; }
            if (PC2.Rank == "10") { PC2Val = 10; }
            if (PC2.Rank == "Jack") { PC2Val = 11; }
            if (PC2.Rank == "Queen") { PC2Val = 12; }
            if (PC2.Rank == "King") { PC2Val = 13; }
            if (PC2.Rank == "Ace") { PC2Val = 14; }

            if (PC3.Rank == "2") { PC3Val = 2; }
            if (PC3.Rank == "3") { PC3Val = 3; }
            if (PC3.Rank == "4") { PC3Val = 4; }
            if (PC3.Rank == "5") { PC3Val = 5; }
            if (PC3.Rank == "6") { PC3Val = 6; }
            if (PC3.Rank == "7") { PC3Val = 7; }
            if (PC3.Rank == "8") { PC3Val = 8; }
            if (PC3.Rank == "9") { PC3Val = 9; }
            if (PC3.Rank == "10") { PC3Val = 10; }
            if (PC3.Rank == "Jack") { PC3Val = 11; }
            if (PC3.Rank == "Queen") { PC3Val = 12; }
            if (PC3.Rank == "King") { PC3Val = 13; }
            if (PC3.Rank == "Ace") { PC3Val = 14; }

            int[] handarr = { PC1Val, PC2Val, PC3Val };
            Array.Sort(handarr);
            bool isInSeq = IsInSequence(PC1Val, PC2Val, PC3Val);


            if (PC1Val == PC2Val && PC1Val == PC3Val) { playerhand = "Three of a kind"; }
            else if ((PC1.Suit == PC2.Suit && PC2.Suit == PC3.Suit)) { playerhand = "Flush"; }

            else if (isInSeq)
            {
                playerhand = "Straight";
            }

            else if (PC1.Suit == PC2.Suit && PC2.Suit == PC3.Suit)
            {

                if (isInSeq) { playerhand = "Straight Flush"; }

            }
            else if (PC1.Rank == PC2.Rank || PC1.Rank == PC3.Rank || PC2.Rank == PC3.Rank)
            {
                if (PC1.Rank == PC2.Rank)
                {
                    Ppair = PC1.Rank.ToString();
                    PHigh = PC1Val;
                }
                else if (PC2.Rank == PC3.Rank)
                {
                    Ppair = PC3.Rank.ToString();
                    PHigh = PC3Val;
                }
                else if (PC1.Rank== PC3.Rank)
                {
                    Ppair = PC1.Rank.ToString();
                    PHigh = PC1Val;
                }
                playerhand = $"Pair";
            }
            else if (PC1.Rank != PC2.Rank || PC1.Rank != PC3.Rank || PC2.Rank != PC3.Rank)
            {

                playerhand = $"High Card";
                PHigh = handarr[2];
                //playerhand = $"High of {handarr[2]}";
            }
            PlayerHandtxt.Text = playerhand;






        }

        private void button1_Click(object sender, EventArgs e) //cotinue button forgot to change name
        {

            button1.Enabled = false;

            Card DC1 = Deck2.Deal();
            Image DC1img = Image.FromFile($"Cards/{DC1.Rank}_of_{DC1.Suit}.png");
            DealerCard1.Image = DC1img;
            DealerCard1txt.Text = (DC1.Rank +" of "+ DC1.Suit);

            Card DC2 = Deck2.Deal();
            Image DC2img = Image.FromFile($"Cards/{DC2.Rank}_of_{DC2.Suit}.png");
            DealerCard2.Image = DC2img;
            DealerCard2txt.Text = (DC2.Rank +" of "+ DC2.Suit);

            Card DC3 = Deck2.Deal();
            Image DC3img = Image.FromFile($"Cards/{DC3.Rank}_of_{DC3.Suit}.png");
            DealerCard3.Image = DC3img;
            DealerCard3txt.Text = (DC3.Rank +" of "+ DC3.Suit);



            if (DC1.Rank == "2") { DC1Val = 2; }
            if (DC1.Rank == "3") { DC1Val = 3; }
            if (DC1.Rank == "4") { DC1Val = 4; }
            if (DC1.Rank == "5") { DC1Val = 5; }
            if (DC1.Rank == "6") { DC1Val = 6; }
            if (DC1.Rank == "7") { DC1Val = 7; }
            if (DC1.Rank == "8") { DC1Val = 8; }
            if (DC1.Rank == "9") { DC1Val = 9; }
            if (DC1.Rank == "10") { DC1Val = 10; }
            if (DC1.Rank == "Jack") { DC1Val = 11; }
            if (DC1.Rank == "Queen") { DC1Val = 12; }
            if (DC1.Rank == "King") { DC1Val = 13; }
            if (DC1.Rank == "Ace") { DC1Val = 14; }
            if(DC1.Suit== "Hearts") { DC1Suit = 1; }
            if(DC1.Suit== "Diamonds") { DC1Suit = 2; }
            if(DC1.Suit== "Clubs") { DC1Suit = 3; }
            if(DC1.Suit== "Spades") { DC1Suit = 4; }


            if (DC2.Rank == "2") { DC2Val = 2; }
            if (DC2.Rank == "3") { DC2Val = 3; }
            if (DC2.Rank == "4") { DC2Val = 4; }
            if (DC2.Rank == "5") { DC2Val = 5; }
            if (DC2.Rank == "6") { DC2Val = 6; }
            if (DC2.Rank == "7") { DC2Val = 7; }
            if (DC2.Rank == "8") { DC2Val = 8; }
            if (DC2.Rank == "9") { DC2Val = 9; }
            if (DC2.Rank == "10") { DC2Val = 10; }
            if (DC2.Rank == "Jack") { DC2Val = 11; }
            if (DC2.Rank == "Queen") { DC2Val = 12; }
            if (DC2.Rank == "King") { DC2Val = 13; }
            if (DC2.Rank == "Ace") { DC2Val = 14; }
            if (DC2.Suit== "Hearts") { DC2Suit = 1; }
            if (DC2.Suit== "Diamonds") { DC2Suit = 2; }
            if (DC2.Suit== "Clubs") { DC2Suit = 3; }
            if (DC2.Suit== "Spades") { DC2Suit = 4; }

            if (DC3.Rank == "2") { DC3Val = 2; }
            if (DC3.Rank == "3") { DC3Val = 3; }
            if (DC3.Rank == "4") { DC3Val = 4; }
            if (DC3.Rank == "5") { DC3Val = 5; }
            if (DC3.Rank == "6") { DC3Val = 6; }
            if (DC3.Rank == "7") { DC3Val = 7; }
            if (DC3.Rank == "8") { DC3Val = 8; }
            if (DC3.Rank == "9") { DC3Val = 9; }
            if (DC3.Rank == "10") { DC3Val = 10; }
            if (DC3.Rank == "Jack") { DC3Val = 11; }
            if (DC3.Rank == "Queen") { DC3Val = 12; }
            if (DC3.Rank == "King") { DC3Val = 13; }
            if (DC3.Rank == "Ace") { DC3Val = 14; }
            if (DC3.Suit== "Hearts") { DC3Suit = 1; }
            if (DC3.Suit== "Diamonds") { DC3Suit = 2; }
            if (DC3.Suit== "Clubs") { DC3Suit = 3; }
            if (DC3.Suit== "Spades") { DC3Suit = 4; }


            int[] handarr = { DC1Val, DC2Val, DC3Val };
            Array.Sort(handarr);
            bool isInSeq = IsInSequence(DC1Val, DC2Val, DC3Val);

            if (DC1Val == DC2Val && DC1Val == DC3Val) { dealerhand = "Three of a kind"; }
            else if ((DC1Suit == DC2Suit && DC2Suit == DC3Suit)) { dealerhand = "Flush"; }
            
            else if (isInSeq)
            {
                dealerhand = "Straight";
            }

            else if (DC1.Suit == DC2.Suit && DC2.Suit == DC3.Suit)
            {

                if (isInSeq) { dealerhand = "Straight Flush"; }

            }
            else if (DC1.Rank == DC2.Rank || DC1.Rank == DC3.Rank || DC2.Rank == DC3.Rank) 
            {
                if (DC1.Rank == DC2.Rank)
                {
                    Dpair = DC1.Rank.ToString();
                    DHigh = DC1Val;
                }
                else if(DC2.Rank == DC3.Rank)
                {
                    Dpair = DC3.Rank.ToString();
                    DHigh = DC3Val;
                }
                else if(DC1.Rank== DC3.Rank)
                {
                    Dpair = DC1.Rank.ToString();
                    DHigh = DC1Val;
                }
                dealerhand = $"Pair";
            }
            else if (DC1.Rank != DC2.Rank || DC1.Rank != DC3.Rank || DC2.Rank != DC3.Rank)
            {

                dealerhand = $"High Card";
                DHigh = handarr[2];
                //dealerhand = $"High of {handarr[2]}";
            }
            DealerHandtxt.Text = dealerhand;
            WinCondition();
        }

        private void Reset()
        {
            PlayerCard1.Image =Image.FromFile("Cards/Flipped_Over.png");
            PlayerCard2.Image =Image.FromFile("Cards/Flipped_Over.png");
            PlayerCard3.Image =Image.FromFile("Cards/Flipped_Over.png");
            DealerCard1.Image =Image.FromFile("Cards/Flipped_Over.png");
            DealerCard2.Image =Image.FromFile("Cards/Flipped_Over.png");
            DealerCard3.Image =Image.FromFile("Cards/Flipped_Over.png");
            Startbtn.Enabled = true;
            ResetbtnEnd.Visible= false;
            ResetbtnEnd.Enabled = false;
            Winnertxt.Text=("");
            PlayerHandtxt.Text=("");
            DealerHandtxt.Text=("");
            PlayerCard1txt.Text=("");
            PlayerCard2txt.Text=("");
            PlayerCard3txt.Text=("");
            DealerCard1txt.Text=("");
            DealerCard2txt.Text=("");
            DealerCard3txt.Text=("");
            Bet = 0;



        }
        private void WinCondition()
        {
            
            ResetbtnEnd.Enabled = true;
            ResetbtnEnd.Visible = true;
            Winnertxt.Visible = true;
            //MessageBox.Show("Win Con Run");
            //decides whos hand is better
            if (playerhand == "Straight Flush") { PHandVal = 6; }
            else if (playerhand == "Three Of A Kind") { PHandVal = 5; }
            else if (playerhand == "Straight") { PHandVal=4; }
            else if (playerhand == "Flush") { PHandVal=3; }
            else if(playerhand == "Pair") { PHandVal=2; }
            else if(playerhand == "High Card") { PHandVal=1; }

            if (dealerhand == "Straight Flush") { DHandVal = 6; }
            else if (dealerhand == "Three Of A Kind") { DHandVal = 5; }
            else if (dealerhand == "Straight") { DHandVal=4; }
            else if (dealerhand == "Flush") { DHandVal=3; }
            else if (dealerhand == "Pair") { DHandVal=2; }
            else if (dealerhand == "High Card") { DHandVal=1; }

            if(PHandVal > DHandVal) 
            {
                Winnertxt.Text = ($"Player Wins!");        
                Bal = Bal + Bet;
                Baltxt.Text = ($"Balance: {Bal}");
            }
            else if (DHandVal > PHandVal) 
            { 
                Winnertxt.Text = ($"Dealer Wins!");
                Bal = Bal - Bet;
                Baltxt.Text = ($"Balance: {Bal}");
            }
            else if(DHandVal == 1 && PHandVal == 1) 
            {
                if(PHigh > DHigh) 
                { 
                    Winnertxt.Text = ("Player Wins!");
                    Bal = Bal + Bet;
                    Baltxt.Text = ($"Balance: {Bal}");
                }
                else if(PHigh < DHigh) 
                { 
                    Winnertxt.Text = ("Dealer Wins!");
                    Bal = Bal - Bet;
                    Baltxt.Text = ($"Balance: {Bal}");
                }
                else if (PHigh == DHigh) { Winnertxt.Text = ("Tie"); }
            }
            else if(DHandVal == 2 && PHandVal == 2)
            {
                if (PHigh > DHigh) 
                { 
                    Winnertxt.Text = ("Player Wins!");
                    Bal = Bal + Bet;
                    Baltxt.Text = ($"Balance: {Bal}");
                }
                else if (PHigh < DHigh) 
                { 
                    Winnertxt.Text = ("Dealer Wins!");
                    Bal = Bal - Bet;
                    Baltxt.Text = ($"Balance: {Bal}");
                }
                else if (PHigh == DHigh) { Winnertxt.Text = ("Tie"); }
            }
            else
            {
                Winnertxt.Text = ("Tie");
            }
            if(Bal <= 0) 
            { 
                Winnertxt.Text = ("No Money!"); 
                ResetbtnEnd.Enabled = false;
            }
        }
    }


}
