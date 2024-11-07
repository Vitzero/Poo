namespace att10;

public abstract class Instrumento : IInstrumentoMusical
{
    public string Nome { get; set; }

    public Instrumento(string nome)
    {
        Nome = nome;
    }

    public abstract void Tocarnota(string nota);
    
}