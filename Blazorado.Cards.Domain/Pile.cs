using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorado.Cards.Domain;


public abstract class Pile
{
    protected List<Card> CardList { get; } = new();

    public ReadOnlyCollection<Card> Cards => CardList.AsReadOnly();

    public  bool IsEmpty => CardList.Count == 0;

}