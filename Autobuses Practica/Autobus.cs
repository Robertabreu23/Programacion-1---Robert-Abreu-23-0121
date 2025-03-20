using System;
using System.Collections.Generic;

public class Autobus
{
    public string Nombre { get; set; }
    public int AsientosDisponibles { get; set; }
    public int Ventas { get; set; }
    public List<Pasajero> Pasajeros { get; set; }
    public int PrecioPorPasaje { get; set; }

    public Autobus(string nombre, int asientos, int precio)
    {
        Nombre = nombre;
        AsientosDisponibles = asientos;
        PrecioPorPasaje = precio;
        Pasajeros = new List<Pasajero>();
        Ventas = 0;
    }

    public void VenderPasaje(Pasajero pasajero)
    {
        if (AsientosDisponibles > 0)
        {
            Pasajeros.Add(pasajero);
            Ventas += PrecioPorPasaje;
            AsientosDisponibles--;
        }
        else
        {
            Console.WriteLine("No hay asientos disponibles.");
        }
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"{Nombre} - {Pasajeros.Count} Pasajeros | Ventas {Ventas} | Quedan {AsientosDisponibles} asientos disponibles");
    }
}
