namespace att10;

public class Piano : Instrumento
{
    public Piano() : base("Piano")
    {
        
    }

    public override void Tocarnota(string nota)
    {
        Console.WriteLine($"o instrumento {Nome}, esta tocando a nota {nota}!");
    }
}