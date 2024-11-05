namespace att2;

class Program
{
    static void Main(string[] args)
    {
        List<I_Funcionario> funcionarios = new List<I_Funcionario>();
        
        funcionarios.Add(new Gerente("tainer",40, 15000,5000));
        funcionarios.Add(new Operario("joao", 22, 37, 47));

        foreach (var funcionario in funcionarios)
        {
            Console.WriteLine($"o salário do gerente {((Funcionario)funcionario).Nome}" +
                              $" de {((Funcionario)funcionario).Idade} anos," +
                              $" é: {funcionario.CalcularSalario().ToString("F2")}.");
        }
        
    }
    
}

