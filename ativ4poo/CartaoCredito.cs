namespace att4;

public class CartaoCredito : Pagamento
{
    private string _numeroCartaoCredito { get; set; }
    
    public CartaoCredito(decimal valor,string numeroCartao) : base(valor)
    {
        _numeroCartaoCredito = numeroCartao;
    }

    public override void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento: crédito | Valor: {valor.ToString("F2")}");
    }
}