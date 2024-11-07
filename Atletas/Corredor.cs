namespace att12;

public class Corredor : Atleta
{
    public Corredor(string nome) : base(nome)
    {
        
    }

    public override void Treinar()
    {
        Console.WriteLine($"O corredor {Name} está correndo.");
    }
}