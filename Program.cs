using System.Dynamic;
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
    public void Roll()
    {
        Random obj = new();
        face = obj.Next(1, numSides);
    }
    public int Face
    {
        get
        {
            return face;
        }
    }
}
class Program
{
    static void Main()
    {
        Dice d1 = new();
        Dice d2 = new(12);
        Dice d3 = new(-20);
        Dice d4 = new(0);
        d1.Roll();
        d2.Roll();
        d3.Roll();
        d4.Roll();
        Console.WriteLine(d1.Face);
        Console.WriteLine(d2.Face);
        Console.WriteLine(d3.Face);
        Console.WriteLine(d4.Face);
        int p1 = 0, p2 = 0;
        Dice D1 = new();
        Dice D2 = new();
        for (int i = 0; i < 5; i++)
        {
            D1.Roll();
            D2.Roll();
            if (D1.Face > D2.Face)
            {
                p1++;
            }
            else
            {
                p2++;
            }
        }
        Console.WriteLine((p1 > p2) ? "Dice one won more rolls" : "Dice two won more rolls");
        Console.WriteLine(p1+"-"+p2);
    }
}