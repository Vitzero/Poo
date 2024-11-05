namespace att2;

public abstract class Funcionario : I_Funcionario
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Funcionario(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    
    public abstract decimal CalcularSalario();
    
    public Funcionario(string nome) : this("joao", 19)
    {
        
    }
}