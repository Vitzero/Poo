namespace att2;

public class Gerente : Funcionario
{
    public Gerente(string nome, int idade, double salario, double bonus) : base(nome, idade)
    {
        Salario = salario;
        Bonus = bonus;
    }

    public double Salario;
    public double Bonus;

    public override decimal CalcularSalario()
    {
        return (decimal)(Salario + Bonus);
    }
    
}