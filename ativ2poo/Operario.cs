namespace att2;

public class Operario : Funcionario
{
    public Operario(string nome, int idade, decimal salarioHora, int horastrabalhadas) : base(nome, idade)
    {
        SalarioHora = salarioHora;
        HorasTrabalhadas = horastrabalhadas;
    }

    public decimal SalarioHora { get; set; }
    public int HorasTrabalhadas { get; set; }

    public override decimal CalcularSalario()
    {
        return SalarioHora * HorasTrabalhadas;
    }
}