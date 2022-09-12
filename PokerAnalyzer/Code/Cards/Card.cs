namespace PokerAnalyzer.Code.Cards;

public record struct Card(Rangs Rang, Suits Suit)
{
    public override string ToString()
    {
        return $"{Rang}-{Suit}";
    }
}