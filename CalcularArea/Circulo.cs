namespace att7;

public class Circulo : FormaGeometrica
{
    public double Raio { get; set; }

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public override double CalcularArea()
    {
        double Area = Math.PI * Raio * Raio;
        return Area;
    }

    public override string ToString()
    {
        return $"Circulo: {Raio}";
    }
}