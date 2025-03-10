using System;

public class Paloma : Ave
{
    // Constructor
    public Paloma(string nombre, int edad) : base(nombre, edad)
    {
    }

    // Implementación del método abstracto
    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} hace un sonido de arrullo.");
    }
}
