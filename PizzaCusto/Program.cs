namespace att9;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"para o tamanho da pizza de mussarela qual tamanho quer? 'Grande' ou 'Média'.");
        string TamanhoDaPizza = Console.ReadLine();
        Console.WriteLine($"para o tamanho da pizza de calabresa qual tamanho quer? 'Grande' ou 'Média'.");
        string TamanhoDaPizza2 = Console.ReadLine();
        Pizza mussarela = new PizzaMussarela(TamanhoDaPizza, 20);
        Pizza calabresa = new PizzaCalabresa(TamanhoDaPizza2, 33);

        Console.WriteLine($"A pizza de mussarela custará {mussarela.CalcularPreco().ToString("F2")}");
        
        Console.WriteLine($"A pizza de calabresa custará {calabresa.CalcularPreco().ToString("F2")}");
    }
}