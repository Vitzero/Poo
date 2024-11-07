namespace att12;

class program
{
    static void Main(string[] args)
    {
        Atleta corredor = new Corredor("joao");
        Atleta corredor2 = new Corredor("juan");
        Atleta nadador = new Nadador("felps");
        
        corredor.Treinar();
        corredor2.Treinar();
        nadador.Treinar();
    }
}