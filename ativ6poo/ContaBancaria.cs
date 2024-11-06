namespace att6;

public abstract class ContaBancaria
{
    public ContaBancaria(string numeroconta, decimal saldo)
    {
        _numeroConta = numeroconta;
        _saldo = saldo;
    }
    
    private string _numeroConta { get; set; }
    protected decimal _saldo { get; set; }
    
    public abstract void Sacar(decimal valor);

    public void Depositar(decimal valor)
    {
        Console.WriteLine($"Deposito de {valor}");
    }
}