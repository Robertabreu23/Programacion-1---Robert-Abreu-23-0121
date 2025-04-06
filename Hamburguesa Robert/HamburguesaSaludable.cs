using System;
using System.Collections.Generic;

public class HamburguesaSaludable : Hamburguesa
{
    private List<(string nombre, double precio)> saludables = new List<(string, double)>();

    public HamburguesaSaludable(string tipoCarne, double precioBase)
        : base("Pan Integral", tipoCarne, precioBase)
    {
        limiteAdicionales = 6;
    }

    public override void AgregarAdicional(string nombre, double precio)
    {
        if (adicionales.Count + saludables.Count >= limiteAdicionales)
        {
            Console.WriteLine("No se pueden agregar más ingredientes saludables.");
            return;
        }

        saludables.Add((nombre, precio));
        Console.WriteLine($"Ingrediente saludable agregado: {nombre} (${precio})");
    }

    public override void MostrarFactura()
    {
        double total = precioBase;
        Console.WriteLine("\n--- Factura de Hamburguesa Saludable ---");
        Console.WriteLine($"Pan: {tipoPan}, Carne: {tipoCarne}, Precio base: ${precioBase}");

        foreach (var adicional in saludables)
        {
            Console.WriteLine($"Adicional saludable: {adicional.nombre} (+${adicional.precio})");
            total += adicional.precio;
        }

        Console.WriteLine($"Total a pagar: ${total}\n");
    }
}
