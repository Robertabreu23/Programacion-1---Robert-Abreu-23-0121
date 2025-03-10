using System;

public class Aguila : Ave
{
    // Constructor
    public Aguila(string nombre, int edad) : base(nombre, edad)
    {
    }

    // Implementación del método abstracto
    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} hace un grito fuerte.");
    }
}
