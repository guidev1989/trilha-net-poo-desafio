using System;

abstract class Smartphone
{
    public string Numero { get; set; }
    public string Modelo { get; private set; }
    public string IMEI { get; private set; }
    public int Memoria { get; private set; }

    public Smartphone(string modelo, string imei, int memoria)
    {
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

    public abstract void Ligar();
    public abstract void ReceberLigacao();
    public abstract void InstalarAplicativo(string nome);
}

class Nokia : Smartphone
{
    public Nokia(string modelo, string imei, int memoria) : base(modelo, imei, memoria)
    {
    }

    public override void Ligar()
    {
        Console.WriteLine("Ligando Nokia...");
    }

    public override void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação no Nokia...");
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando aplicativo {nome} no Nokia...");
    }
}

class Iphone : Smartphone
{
    public Iphone(string modelo, string imei, int memoria) : base(modelo, imei, memoria)
    {
    }

    public override void Ligar()
    {
        Console.WriteLine("Ligando iPhone...");
    }

    public override void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação no iPhone...");
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando aplicativo {nome} no iPhone...");
    }
}

class Program
{
    static void Main()
    {
        Nokia nokia = new Nokia("Nokia XYZ", "987654321", 64);
        Iphone iphone = new Iphone("iPhone 12", "123456789", 128);

        // Exemplo de uso
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
