using System.Collections.Generic;

public class Deck
{
    private Stack<string> deck = new Stack<string>();
    public string[] Cards { get; set; } = new string[]
    {
        "Queen of Hearts",
        "King of Diamonds",
        "King of Spades",
        "2 of Diamonds",
        "6 of Clubs"
    };

    public Deck()
    {
        deck.Push("8 of Hearts");
        deck.Push("10 of Spades");
    }

    public string DrawCard(string item)
    {
        deck.Push(item);
        return "You picked up: " + item;
    }
    public string RemoveCard()
    {
        if (deck.Count > 0)
        {
            return "You removed: " + deck.Pop();
        }
        return "You have nothing to remove";
    }
    public string CheckCard()
    {
        if (deck.Count > 0)
        {
            return deck.Peek();
        }
        return "No card exist";
    }
}
