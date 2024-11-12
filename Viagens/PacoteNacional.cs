namespace att14;

public class PacoteNacional : PacoteTuristico
{
    public int Dias { get; set; }

    public PacoteNacional(string destino, int dias) : base(destino)
    {
        Dias = dias;
    }

    public override decimal CalcularPreco()
    {
        return Dias * 200;
    }
}