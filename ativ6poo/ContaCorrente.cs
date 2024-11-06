namespace att6;

public class ContaCorrente : ContaBancaria
{
    private decimal LimiteChequeEspecial { get; set; }
    public ContaCorrente(string numeroconta,decimal saldoInicial, decimal limiteChequeEspecial) : base(numeroconta, saldoInicial)
    {
        decimal LimiteChequeEspecial = limiteChequeEspecial;
    }
    
    public override void Sacar(decimal valor)
    {
        
        decimal saldoTotalDisponivel = _saldo + LimiteChequeEspecial;
    }
}