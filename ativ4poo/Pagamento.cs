namespace att4;

public abstract class Pagamento : IPagamento
{
    public decimal Valor { get; set; }
    
    public Pagamento(decimal valor)
    {
        Valor = valor;
    }

    public abstract void ProcessarPagamento(decimal valor);
    

}