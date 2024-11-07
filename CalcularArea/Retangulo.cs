namespace att7;

public class Retangulo : FormaGeometrica
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }
    
    public override double CalcularArea()
    {
        double Area = Largura * Altura;
        return Area;
    }

    public override string ToString()
    {
        return $"Largura: {Largura}, Altura: {Altura}";
    }
}