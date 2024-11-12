namespace att13;

public class PratoPrincipal : Pratos
{
    public PratoPrincipal(string nomePrato) : base(nomePrato)
    { }

    public override int tempoDePreparo()
    {
        return 30;
    }
}