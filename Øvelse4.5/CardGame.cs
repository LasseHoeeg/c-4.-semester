using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4._5
{
    internal class CardGame
    {
        public List<Card> Cards = new List<Card>();


        public void AddCard(Suit suit, Number number)
        {
            Card card =  new Card(number, suit);
            Cards.Add(card);
        }

        public List<Card> filterCardGame(FilterCardDelegate filter) 
        {
            List<Card> filterdCards = new List<Card>(); //Der skal tilføjes til listen
            foreach(Card card in Cards)
            {
                if (filter.Invoke(card) == true)
                {
                    filterdCards.Add(card);
                }
                
            }


            return filterdCards;

        }

    }






}
