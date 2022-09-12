using System;
using System.Collections.Generic;
using PokerAnalyzer.Code.Cards;

namespace PokerAnalyzer.Code;

public class Table
{
    public static class Functions
    {
        public static IReadOnlyList<Card> CreateStack()
        {
            var rangs = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            var suits = new int[] { 0, 1, 2, 3 };

            var stack = new List<Card>(52);

            foreach (var rang in rangs)
            {
                foreach (var suit in suits)
                {
                    stack.Add(new Card((Rangs)rang, (Suits)suit));
                }
            }

            return stack;
        }
    }
    public IReadOnlyList<Player> Players { get; init; }
    public IReadOnlyList<Card> Stack { get; init; }
    public List<Card> Cards { get; init; }
    public int Bank { get; set; }

    public Table(IReadOnlyList<Player> players, IReadOnlyList<Card> stack)
    {
        Players = players;
        Stack = stack;
        
        Cards = new List<Card>();
        
        Bank = 0;
    }
}

public class Player
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public bool Active { get; set; }
}