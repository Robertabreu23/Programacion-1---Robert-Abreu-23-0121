using System;

internal class Dispositivo
{
    public required string Marca { get; set; }
    public void Encender() => Console.WriteLine("Dispositivo encendido.");
}

internal interface IRecargable
{
    void Recargar();
}

internal class Smartphone : Dispositivo, IRecargable
{
    public void HacerLlamada() => Console.WriteLine("Llamando...");
    public void Recargar() => Console.WriteLine("Recargando smartphone...");
}

internal class Program
{
    private static void Main()
    {
        Smartphone miTelefono = new Smartphone { Marca = "Samsung" };
        miTelefono.Encender();
        miTelefono.HacerLlamada();
        miTelefono.Recargar();
    }
}
