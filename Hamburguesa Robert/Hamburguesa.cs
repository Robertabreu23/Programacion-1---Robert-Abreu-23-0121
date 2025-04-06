using System;
using System.Collections.Generic;

public class Hamburguesa
{
    protected string tipoPan;
    protected string tipoCarne;
    protected double precioBase;
    protected List<(string nombre, double precio)> adicionales = new List<(string, double)>();
    protected int limiteAdicionales = 4;

    public Hamburguesa(string tipoPan, string tipoCarne, double precioBase)
    {
        this.tipoPan = tipoPan;
        this.tipoCarne = tipoCarne;
        this.precioBase = precioBase;
    }

    public virtual void AgregarAdicional(string nombre, double precio)
    {
        if (adicionales.Count >= limiteAdicionales)
        {
            Console.WriteLine("No se pueden agregar más ingredientes adicionales.");
            return;
        }

        adicionales.Add((nombre, precio));
        Console.WriteLine($"Ingrediente agregado: {nombre} (${precio})");
    }

    public virtual void MostrarFactura()
    {
        double total = precioBase;
        Console.WriteLine("\n--- Factura de Hamburguesa ---");
        Console.WriteLine($"Pan: {tipoPan}, Carne: {tipoCarne}, Precio base: ${precioBase}");

        foreach (var adicional in adicionales)
        {
            Console.WriteLine($"Adicional: {adicional.nombre} (+${adicional.precio})");
            total += adicional.precio;
        }

        Console.WriteLine($"Total a pagar: ${total}\n");
    }
}
