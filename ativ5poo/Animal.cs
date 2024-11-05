namespace att5;

public abstract class Animal
{
    
    public string Nome { get; set; }

    public Animal(string nome)
    {
        Nome = nome;
    }
    public abstract void EmitirSom();
}