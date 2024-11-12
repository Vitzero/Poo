namespace att14;

public class PacoteInternacional : PacoteTuristico
{
    public int Dias { get; set; }

    public PacoteInternacional(string destino, int dias) : base(destino)
    {
        Dias = dias;
    }

    public override decimal CalcularPreco()
    {
        return Dias * 500;
    }
}