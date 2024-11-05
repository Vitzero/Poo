namespace att5;

public class Mamifero : Animal
{
    public Mamifero(string nome) : base(nome)
    {
        
    }

    public override void EmitirSom()
    {
        Console.WriteLine($"O mamifero faz som de mamifero {this.Nome}");
    }
}