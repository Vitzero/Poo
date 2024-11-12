namespace att15;

public class Televisao : Dispositivo
{
    public Televisao(string marca) : base(marca)
    {
        
    }

    public override void Desligar()
    {
        Console.WriteLine($"A sua televisão desligou!");
    }

    public override void Ligar()
    {
        Console.WriteLine($"Televisão Ligada!");
    }
}