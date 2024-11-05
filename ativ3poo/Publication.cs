namespace att3;

public abstract class Publication
{
    public string Title { get; set; }
    public string Author { get; set; }

    public abstract decimal PenaltyTax(decimal days);

    public Publication(string title, string author)
    {
        Title = title;
        Author = author;
    }
}