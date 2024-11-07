namespace att9;

public class PizzaCalabresa : Pizza
{
    private decimal _preco { get; set; }
    public PizzaCalabresa(string tamanho,decimal preco) : base(tamanho)
    {
        _preco = preco;
    }

    public override decimal CalcularPreco()
    {
        decimal precoFinal = _preco;

        if (Tamanho == "Médio")
        {
            precoFinal += 5;
        }
        else if (Tamanho == "Grande")
        {
            precoFinal += 10;
        }
        return precoFinal;
    }
}