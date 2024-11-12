namespace att13;

public abstract class Pratos
{
    public string Nome { get; set; }

    public Pratos(string nome)
    {
        Nome = nome;
    }

    public abstract int tempoDePreparo();
}