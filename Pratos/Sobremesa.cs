namespace att13;

public class Sobremesa : Pratos
{
    public Sobremesa(string nome) : base(nome)
    {
        
    }

    public override int tempoDePreparo()
    {
        return 15;
    }
}