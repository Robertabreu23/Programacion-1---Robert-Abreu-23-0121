using System;

class Vehiculo
{
    public required string Marca { get; set; }
    public int Año { get; set; }

    public void MostrarInfo()
    {
        Console.WriteLine($"Marca: {Marca}, Año: {Año}");
    }
}

class Auto : Vehiculo
{
    public int Puertas { get; set; }

    public void MostrarDetalles()
    {
        MostrarInfo();
        Console.WriteLine($"Puertas: {Puertas}");
    }
}

class Program
{
    static void Main()
    {
        Auto miAuto = new Auto { Marca = "Toyota", Año = 2022, Puertas = 4 };
        miAuto.MostrarDetalles();
    }
}


