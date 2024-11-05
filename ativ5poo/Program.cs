namespace att5;

class program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        Animal r1 = new Reptil("iguana");
        Animal r2 = new Reptil("tartaruga");
        Animal r3 = new Reptil("cobra");
        Animal m1 = new Mamifero("vaca");
        Animal m2 = new Mamifero("rinoceronte");
        
        animals.Add(r1);
        animals.Add(r2);
        animals.Add(r3);
        animals.Add(m1);
        animals.Add(m2);

        foreach (var animal in animals)
        {
            animal.EmitirSom();
        }
    }
}
