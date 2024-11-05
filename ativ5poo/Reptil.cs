namespace att5;

public class Reptil : Animal
{
    public Reptil(string nome) : base(nome)
    { }

    public override void EmitirSom()
    {
        Console.WriteLine($"o reptil faz som de reptil {this.Nome}");
    }
}