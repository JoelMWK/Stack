public class Prompt
{
    private Deck deck = new Deck();
    private Random random = new Random();
    private int input;

    public void Question()
    {
        Console.WriteLine("*--------------------------*");
        Console.WriteLine("Choose between three actions");
        Console.WriteLine("*--------------------------*");
    }
    public void Action()
    {
        Console.WriteLine("1) Check deck \n2) Remove card \n3) Draw card");

        string action = Console.ReadLine();
        bool result = int.TryParse(action, out input);
        Console.Clear();

        if (!result || input < 1 || input > 3)
        {
            Console.WriteLine("Skill issue");
        }

        if (input == 1)
        {
            Console.WriteLine("Top of deck:");
            Console.WriteLine("-------------");
            Console.WriteLine(deck.CheckCard());
            Console.WriteLine("-------------");
        }
        else if (input == 2)
        {
            Console.WriteLine(deck.RemoveCard());
        }
        else if (input == 3)
        {
            Console.WriteLine(deck.DrawCard(deck.Cards[random.Next(0, deck.Cards.Count())]));
        }
    }
}
