namespace att15;

class program
{
    static void Main(string[] args)
    {
        Dispositivo tv = new Televisao("LG");
        Dispositivo radio = new Radio("Phillips");
        
        tv.Ligar();
        tv.Desligar();
        radio.Ligar();
        radio.Desligar();
        
    }
}

