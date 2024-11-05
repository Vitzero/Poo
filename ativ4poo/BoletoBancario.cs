namespace att4;

public class BoletoBancario : Pagamento
{
    private string CodigoBarras { get; set; }
    public BoletoBancario(decimal valor,string codigoBarras) : base(valor)
    {
        CodigoBarras = codigoBarras;
    }

    public override void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pago com o boleto bancario: {CodigoBarras}| Valor: {valor.ToString("F2")}");
    }
}