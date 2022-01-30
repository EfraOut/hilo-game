public class Director
{
    string userChoice = "";
    Card card = new Card();
    bool isPlaying = true;
    int score = 300;
    string keepPlaying = "";

    public void StartGame()
    {
        while (isPlaying && score != 0)
        {
            GetInputs();
            CompareCards();
            DoOutputs();
        }
    }

    // Asks the user their guess.
    public void GetInputs()
    {   
        int firstCard = card.Deal();
        Console.WriteLine($"The card is: {firstCard}");
        Console.Write("Higher or Lower? [h/l] ");
        string userChoice = Console.ReadLine();
    }

    // Compares the tw cards, depending on what the users inputs
    public void CompareCards()
    {
        string compare = card.Compare();
        Console.WriteLine(compare);

        if (compare == userChoice)
        {
            score += 100;
        }
        else
        {
            score -= 75;
        }
    }

    // Prints on the console the results and asks if they want to keep playing.
    public void DoOutputs()
    {
        Console.WriteLine($"The next card was: {card.nextCard}");
        Console.WriteLine($"Your score is: {score}");
        Console.Write($"Keep Playing? [y/n]: ");
        keepPlaying = Console.ReadLine();
        isPlaying = (keepPlaying == "y");
    }
}
