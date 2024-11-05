namespace att1;

public class Carro : Veiculo
{
    public Carro(string modelo, string placa, int ano) : base(modelo, placa, ano)
    {
        
    }
    public int NumeroDePortas  { get; set; }
    
    public override void CalcularValorAluguel()
    {
        double valorAluguel = 0;
        valorAluguel = (Ano * 0.1) + (NumeroDePortas * 5);
        Console.WriteLine($"aluguel do carro {Modelo}, {Placa}, {Ano}= {valorAluguel} por dia");
    }
    
    
    
}
