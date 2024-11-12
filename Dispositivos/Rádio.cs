namespace att15;

public class Radio : Dispositivo
{
    public Radio(string marca) : base( marca )
    {
        
    }

    public override void Desligar()
    {
        Console.WriteLine("Desligando radio.");
    }

    public override void Ligar()
    {
        Console.WriteLine("Ligando radio.");
    }
}