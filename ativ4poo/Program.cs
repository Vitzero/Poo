namespace att4;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("digite o valor da compra: ");
        decimal valorCompra = Convert.ToDecimal(Console.ReadLine());
        
        Console.WriteLine("qual o metodo de pagamento: 1 = Cartao de credito || 2 = Boleto.");
        int metodoPagamento = Convert.ToInt32(Console.ReadLine());

        Pagamento pagamento;

        switch (metodoPagamento)
        {
            case 1:
                pagamento = new CartaoCredito(valorCompra,"123123");
                break;
            case 2:
                pagamento = new BoletoBancario(valorCompra,"111111");
                break;
            default:
                Console.WriteLine("invalido!");
                return;
        }
        
        pagamento.ProcessarPagamento(valorCompra);
        Console.WriteLine("Pagamento realizado com sucesso!");
    }
}

