namespace att3;

public class Magazine : Publication
{
    public Magazine(string title, string author) : base(title, author)
    {
        
    }

    public override decimal PenaltyTax(decimal days)
    {
        return days * 1.0m;
    }
}