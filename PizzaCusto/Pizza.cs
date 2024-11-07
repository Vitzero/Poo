namespace att9;

public abstract class Pizza
{
    protected string Tamanho { get; set; }

    public Pizza(string tamanho)
    {
        Tamanho = tamanho;
    }
    
    public abstract decimal CalcularPreco();
}