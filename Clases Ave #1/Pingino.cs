using System;

public class Pinguino : Ave
{
    // Constructor
    public Pinguino(string nombre, int edad) : base(nombre, edad)
    {
    }

    // Implementación del método abstracto
    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} hace un sonido suave.");
    }
}
