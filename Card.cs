using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCasino

{
    internal class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }
        public int Value { get; set; }

        public Image Img { get; set; }

        public Card(string suit, string rank,int value ,Image img)
        {
            this.Suit = suit;
            this.Rank = rank;
            this.Img = img;
            this.Value = value;
        }




    }
}
