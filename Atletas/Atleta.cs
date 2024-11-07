namespace att12;

public abstract class Atleta
{
    public string Name { get; set; }

    public Atleta(string name)
    {
        Name = name;
    }

    public abstract void Treinar();
}