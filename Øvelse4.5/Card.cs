using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4._5
{
        enum Number
    {
        Ace,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    delegate bool FilterCardDelegate(Card card);
    internal class Card
    {
        
       public Suit suit { get; set; }
       public Number number { get; set; }

        public Card(Number number, Suit suit) {
            this.suit = suit;
            this.number = number;
        }

        public override string ToString()
        {
            return suit + " " + number;
        }





    }
}
