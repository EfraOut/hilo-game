// A card is a plastic piece of paper that contains a numeric value
//
// The responsabilities of a card is to draw a random card and keep track whether is higher or lower than other card
public class Card
{
    public int nextCard = 0;
    public int currentCard = 0;

    // Constructs a new instance of Cards
    public Card()
    {
    }

    // Gives the value of the first card
    public int Deal()
    {
        Random random = new Random();
        currentCard = random.Next(1, 13);
        return currentCard;
    }

    // Deals the second card and compares it with the first one
    public string Compare()
    {
        nextCard = this.Deal();
        
        if (nextCard < currentCard)
        {
            return "l";
        }
        else
        {
            return "h";
        }
    }
}
