using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorado.Cards.Core;

public class Deck : StackPile
{
    public Deck()
    {
        for (Suit s = Suit.Clubs; s <= Suit.Hearts; s++)
        {
            for (Value v = Value.Ace; v <= Value.King; v++)
            {
                CardList.Add(new Card(s, v));
            }
        }
    }

    public void Shuffle()
    {
        Random rng = new Random();
        for (int i = 0; i < CardList.Count - 1; i++)
        {
            int j = rng.Next(i , CardList.Count);
            Swap(i, j);
        }
    }

    private void Swap(int i, int j)
    {
        Card tmp = CardList[i];
        CardList[i] = CardList[j];
        CardList[j] = tmp;
    }
}
