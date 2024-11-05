namespace att3;

public class Book : Publication
{
    public Book(string title,string author) : base(title, author)
    {
        
    }

    public override decimal PenaltyTax(decimal days)
    {
        return days * 1.5m;
    }
}