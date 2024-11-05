using System;

namespace att1;

class Program
{
    static void Main(string[] args)
    {
        Veiculo c1 = new Carro("audi q3", "sazs123", 2021);
        
        c1.CalcularValorAluguel();

        Veiculo m1 = new Moto("kawasaki z300", "f1220", 2019);
        m1.CalcularValorAluguel();
        
        
        
    }
}

