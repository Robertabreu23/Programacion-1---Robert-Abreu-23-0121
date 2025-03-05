using System;

class Animal
{
    public required string Nombre { get; set; }

    public void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido.");
    }
}

class Perro : Animal
{
    public void Ladrar()
    {
        Console.WriteLine($"{Nombre} dice: ¡Guau!");
    }
}

class Gato : Animal
{
    public void Maullar()
    {
        Console.WriteLine($"{Nombre} dice: ¡Miau!");
    }
}

class Program
{
    static void Main()
    {
        Perro miPerro = new Perro { Nombre = "Galipote" };
        Gato miGato = new Gato { Nombre = "Fausto" };

        miPerro.Ladrar();
        miGato.Maullar();
    }
}
