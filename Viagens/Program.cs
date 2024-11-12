namespace att14;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"digite o pacote que você quer: 1 - Pacote Nacional, 2 - Pacote Internacional");
        int opcao = int.Parse(Console.ReadLine());

        Console.WriteLine($"digite quantos dias quer viajar: ");
        int dias = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"digite o destino: ");
        string destiny = Console.ReadLine();

        switch (opcao)
        {
            case 1:
                PacoteTuristico nacional = new PacoteNacional(destiny, dias);
                Console.WriteLine($"a viagem para {destiny}, de {dias} dias, irá custar {nacional.CalcularPreco().ToString("F2")}!");
                break;
            case 2:
                PacoteTuristico internacional = new PacoteInternacional(destiny, dias);
                Console.WriteLine($"a viagem para {destiny}, de {dias} dias, irá custar {internacional.CalcularPreco().ToString("F2")}!");
                break;
            default:
                Console.WriteLine($"INVÁLIDO!");
                return;
        }
        
        
        
    }
}

