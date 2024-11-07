using System.Net.Sockets;

namespace att7;

class program
{
    static void Main(string[] args)
    {
        List<FormaGeometrica> calculos = new List<FormaGeometrica>();
        
        FormaGeometrica circulo  = new Circulo(15);
        FormaGeometrica retangulo = new Retangulo(15,19);
        
        calculos.Add(circulo);
        calculos.Add(retangulo);

        foreach (var forma in calculos)
        {
            
            Console.WriteLine($"área da forma geografica: {forma.CalcularArea().ToString("F2")}, da forma {forma.ToString()}");
            
        }
    }
}