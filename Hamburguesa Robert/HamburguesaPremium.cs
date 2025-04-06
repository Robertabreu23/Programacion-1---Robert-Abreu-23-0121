using System;

public class HamburguesaPremium : Hamburguesa
{
    public HamburguesaPremium(string tipoPan, string tipoCarne, double precioBase)
        : base(tipoPan, tipoCarne, precioBase)
    {
        adicionales.Add(("Papitas", 2.5));
        adicionales.Add(("Bebida", 1.5));
        limiteAdicionales = 0;
    }

    public override void AgregarAdicional(string nombre, double precio)
    {
        Console.WriteLine("No se pueden agregar ingredientes adicionales a la hamburguesa premium.");
    }

    public override void MostrarFactura()
    {
        double total = precioBase;
        Console.WriteLine("\n--- Factura de Hamburguesa Premium ---");
        Console.WriteLine($"Pan: {tipoPan}, Carne: {tipoCarne}, Precio base: ${precioBase}");

        foreach (var adicional in adicionales)
        {
            Console.WriteLine($"Incluye: {adicional.nombre} (+${adicional.precio})");
            total += adicional.precio;
        }

        Console.WriteLine($"Total a pagar: ${total}\n");
    }
}
