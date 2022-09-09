using System;
using System.Collections.Generic;
using PokerAnalyzer.Code.Cards;

namespace PokerAnalyzer.Code;

public class Table
{
    public IReadOnlyList<Player> Players { get; init; }
    public List<Card> Cards { get; init; }
    public int Stack { get; private set; }
    public int Bank { get; set; }

    public Table(IReadOnlyList<Player> players, int stack)
    {
        Players = players;
        Cards = new List<Card>();
        Stack = stack;
        Bank = 0;
    }
}

public class Player
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public bool Active { get; set; }
}