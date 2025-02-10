using System;

public class Activity
{
    public List<string> Deck {get;} = new List<string>();

    public void CreateDeck()
    {
        string[] suits = {"Heart", "Spade", "Diamond", "Clover"};
        string[] ranks = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};

        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                Deck.Add($"{rank} of {suit}");
            }
        }

    }

    public void Menu()
    {

    }

    public static void Main()
    {

    }
}