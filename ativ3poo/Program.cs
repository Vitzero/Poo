namespace att3;

class program
{
    static void Main(string[] args)
    {
        decimal multa = 0;
        Publication magazine = new Magazine("Improving skills", "tainer");
        Console.WriteLine($"how many days do u missed?");
        decimal.TryParse(Console.ReadLine(), out decimal days);
        multa = magazine.PenaltyTax(days);
        Console.WriteLine($"The tax for {days} days missed is ${multa}");

        Publication book = new Book("Dot.Net is really good?", "tainer");
        Console.WriteLine($"how many days do u missed the book {book.Title}?");
        decimal.TryParse(Console.ReadLine(), out decimal days2);
        multa = book.PenaltyTax(days2);
        Console.WriteLine($"The tax for {days} days missed is ${multa}");
    }
}