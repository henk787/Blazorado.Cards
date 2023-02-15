namespace Blazorado.Cards.Core;

public enum Suit
{
    None,
    Clubs,
    Diamonds,
    Spades,
    Hearts
}

public enum Value
{
    None = 0,
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


public record Card(Suit Suit, Value Value)
{
    public bool FaceUP { get; set; }
}

