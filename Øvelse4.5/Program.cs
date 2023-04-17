


using Øvelse4._5;

class Program
{
    static public bool FilterByKlør(Card card)
    {
        if (card.suit == Suit.Clubs)
            return true;
        else
            return false;
    }

    static public bool FilterByBillede(Card card)
    {
        if (card.number == Number.Jack || card.number == Number.Queen || card.number == Number.King)
            return true;
        else
            return false;
    }
    static public bool FilterByIkkeBillede(Card card)
    {
        if (card.number != Number.Jack || card.number != Number.Queen || card.number != Number.King)
            return true;
        else
            return false;
    }

    static void Main(string[] args)
    {
        CardGame cardGame = new CardGame();

        for(int i = 0; i < 4 ;i++)
        {
            for(int j = 0; j < 14 ; j++)
            {
                cardGame.AddCard((Suit)i, (Number)j);
            }
        }


        var billedKort = cardGame.filterCardGame(FilterByBillede);

        foreach (Card card in billedKort)
        {
            Console.WriteLine(card.ToString());
        }

        //foreach (Card card in cardGame.Cards)
        //{
        //    Console.WriteLine(card.ToString());
        //}




    }
}


