namespace att13;

class program
{
    static void Main(string[] args)
    {
        Pratos Costeleta = new PratoPrincipal("costeleta de carne ao barbecue");
        Pratos Pudim = new PratoPrincipal("pudim de chocolate");

        Console.WriteLine($"o prato principal de {Costeleta.Nome} ficara pronto em {Costeleta.tempoDePreparo()} minutos!");
        
        Console.WriteLine($"a sobremesa principal de {Pudim.Nome} ficara pronto em {Pudim.tempoDePreparo()} minutos!");
    }
}