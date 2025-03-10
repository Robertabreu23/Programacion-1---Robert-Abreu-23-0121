using System;

public abstract class Ave
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    // Constructor
    public Ave(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    // Método abstracto para ser sobrescrito en las clases derivadas
    public abstract void HacerSonido();

    // Método común
    public void Volar()
    {
        Console.WriteLine($"{Nombre} está volando.");
    }

    // Método común
    public void Comer()
    {
        Console.WriteLine($"{Nombre} está comiendo.");
    }
}
