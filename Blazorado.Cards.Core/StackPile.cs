namespace Blazorado.Cards.Core;

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
