using System.Dynamic;
using Cards2;

public class Dice
{
    private int face, numSides;
    public Dice()
    {
        numSides = 6;
        face = 1;
    }
    public Dice(int num)
    {
        if (num != 0)
        {
            numSides = Math.Abs(num);
        }
        else
        {
            numSides = 6;
        }
    }
    public int Roll()
    {
        Random obj = new();
        face = obj.Next(1, numSides);
        return face;
    }
}

class Program
{
    static void Main()
    {
        List<Card> Player1 = new();
        List<Card> Player2 = new();
        List<Card> Player3 = new();
        List<Card> Player4 = new();
        int PlayerNum = 1, ChallengerNum = 2, CurrentRoller, NextRoller;
        Dice dice = new();
        while (ChallengerNum != 5)
        {
            CurrentRoller = dice.Roll();
            NextRoller = dice.Roll();
            if (CurrentRoller != NextRoller)
            {
                Console.WriteLine($"Player {PlayerNum} rolled {CurrentRoller}, Player {ChallengerNum} rolled {NextRoller}");
                PlayerNum = (CurrentRoller > NextRoller) ? PlayerNum : ChallengerNum;
                ChallengerNum++;
            }
            else
            {
                Console.WriteLine($"Tied Player {PlayerNum} and Player {ChallengerNum} rolled a(n) {CurrentRoller}");
            }
        }
        Console.WriteLine($"Player {PlayerNum} is the dealer");
        Deck deck = new();
        deck.Shuffle();
        for (int i = 0; i < 52; i++)
        {
            if (PlayerNum == 5)
            {
                PlayerNum = 1;
            }
            if (PlayerNum == 1)
            {
                Player1.Add(deck.TakeTopCard());
            }
            else if (PlayerNum == 2)
            {
                Player2.Add(deck.TakeTopCard());
            }
            else if (PlayerNum == 3)
            {
                Player3.Add(deck.TakeTopCard());
            }
            else
            {
                Player4.Add(deck.TakeTopCard());
            }
            PlayerNum++;

        }
        Console.WriteLine($"Player1 Card:{Player1.Count}");

        for (int i = 0; i < Player1.Count; i++)
        {
            Console.WriteLine(Player1[i].Rank + " of " + Player1[i].Suit);
        }
        Console.WriteLine($"Player2 Card:{Player2.Count}");
        for (int i = 0; i < Player2.Count; i++)
        {
            Console.WriteLine(Player2[i].Rank + " of " + Player2[i].Suit);
        }
        Console.WriteLine($"Player3 Card:{Player3.Count}");
        for (int i = 0; i < Player3.Count; i++)
        {
            Console.WriteLine(Player3[i].Rank + " of " + Player3[i].Suit);
        }
        Console.WriteLine($"Player4 Card:{Player4.Count}");
        for (int i = 0; i < Player4.Count; i++)
        {
        Console.WriteLine(Player4[i].Rank + " of " + Player4[i].Suit);
        }
    }
}