namespace att1;

public class Moto : Veiculo
{
    public Moto(string modelo, string placa, int ano) : base(modelo, placa, ano)
    {
    }

    public bool TemSideCar = false;

    public void MotoSideCar(bool resposta)
    {
        if (resposta == true)
        {
            TemSideCar = true;
        }
        else
        {
            TemSideCar = false;
        }
    }
    
    public override void CalcularValorAluguel()
    {
        double valorAluguel = 0;
        valorAluguel = (Ano * 0.05) + (TemSideCar ? 20 : 0);
        Console.WriteLine($"aluguel da moto {Modelo}, {Placa}, {Ano} = {valorAluguel} por dia");
    }
}