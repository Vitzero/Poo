namespace att1;

public abstract class Veiculo
{
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    
    abstract public void CalcularValorAluguel();

    public Veiculo(string placa, string modelo, int ano)
    {
        Placa = placa;
        Modelo = modelo;
        Ano = ano;
    }

    public Veiculo(string nome) : this("mar09", "bmw", 2015)
    {
        
    }
}