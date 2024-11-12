namespace att15;

public abstract class Dispositivo : IDispositivo
{
    public string Marca { get; set; }

    public Dispositivo(string marca)
    {
        Marca = marca;
    }

    public abstract void Ligar();

    public abstract void Desligar();



}