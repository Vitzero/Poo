namespace att10;

public class Violao : Instrumento
{
    public Violao() : base("Violão")
    {
        
    }

    public override void Tocarnota(string nota)
    {
        Console.WriteLine($"o instrumento {Nome}, está tocando a nota {nota}!");
    }
}