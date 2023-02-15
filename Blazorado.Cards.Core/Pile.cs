using System.Collections.ObjectModel;

namespace Blazorado.Cards.Core;

public abstract class Pile
{
    protected List<Card> CardList { get; } = new();

    public ReadOnlyCollection<Card> Cards => CardList.AsReadOnly();

    public  bool IsEmpty => CardList.Count == 0;

}