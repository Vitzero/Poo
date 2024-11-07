namespace att10;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"que nota quer tocar nos instrumentos?");
        string nota = Console.ReadLine();
        
        Instrumento violao = new Violao();
        Instrumento piano = new Piano();
        
        violao.Tocarnota(nota);
        piano.Tocarnota(nota);
        
    }
}

