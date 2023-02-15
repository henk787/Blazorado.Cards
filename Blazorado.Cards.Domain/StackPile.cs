using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorado.Cards.Domain
{
    public class StackPile : Pile
    {
        
        public void Push(Card card)
        {
            CardList.Add(card);
        }

        public Card Pop() 
        {
            if (IsEmpty) throw new InvalidOperationException();

            Card card = CardList[CardList.Count - 1];
            CardList.RemoveAt(CardList.Count - 1);
            return card;
        }

    }
}
