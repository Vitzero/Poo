namespace att12;

public class Nadador : Atleta
{
    public Nadador(string nome) : base(nome)
    {
        
    }

    public override void Treinar()
    {
        Console.WriteLine($"Nadador {Name} está nadando.");
    }
}