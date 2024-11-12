namespace att14;

public abstract class PacoteTuristico
{
    public string Destino { get; set; }

    public PacoteTuristico(string destino)
    {
        Destino = destino;
    }

    public abstract decimal CalcularPreco();
}