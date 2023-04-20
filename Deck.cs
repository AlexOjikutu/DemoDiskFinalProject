using DemoDisk.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCasino
{
    internal class Deck
    {
        private static readonly string[] Suits = { "Spades", "Hearts", "Clubs", "Diamonds" };
        private static readonly string[] Ranks = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King","Ace" };



        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            foreach (string suit in Suits)
            {
                for (int i = 0; i < Ranks.Length; i++)
                {
                    string rank = Ranks[i];
                    int value = i + 2;
                    if (i >= 9) value = 10; // Jack, Queen, King are worth 10
                    if (i == 12) value = 11; // Ace is worth 11 or 1

                    Image img = Image.FromFile($"Cards/{rank}_of_{suit}.png");
                    Card card = new Card(suit, rank, value,img);
                    cards.Add(card);
                }
            }

        }
        public void ResetDeck()
        {
            cards.Clear();
            
        }

        public void Shuffle()
        {
            Random rng = new Random();// makes a new random object
            int n = cards.Count; // makes var to keep track of cards in deck
            while (n > 1) // loops until one card left in deck
            {
                // fair shuffle using fisher Yates method
                n--;
                int k = rng.Next(n + 1); // generates a random int 0 - n and assigns it to k
                Card card = cards[k]; //stores the card at index k in a temporary variable called card
                cards[k] = cards[n]; // swaps the card at index k with the card at index n
                cards[n] = card; // puts the card that was originally at index k (stored in the card variable) into the position at index n
            }
        }

        public Card Deal()
        {
            Card card = cards[0]; // chooses first card in deck
            cards.RemoveAt(0); //removes that card from deck
            cards.Add(card );
            return card; // saves the value
        }
        /*public void Reset()
        {
            Shuffle();
        }
        */


    }

}

