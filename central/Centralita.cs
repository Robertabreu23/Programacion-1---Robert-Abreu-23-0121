using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

public class Centralita
{
    private List<Llamada> llamadas;

    public Centralita()
    {
        llamadas = new List<Llamada>();
    }

    public void RegistrarLlamadaInteractiva()
    {
        Console.Write("Ingrese su número de origen: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string numeroOrigen = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        Console.Write("Ingrese el número de destino: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string numeroDestino = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        Console.Write("Seleccione el tipo de llamada (1: Local, 2: Provincial): ");
#pragma warning disable CS8604 // Possible null reference argument.
        int tipoLlamada = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

        Stopwatch cronometro = new Stopwatch();
        Console.WriteLine("Marcando... Presione ENTER para finalizar la llamada.");
        cronometro.Start();
        Console.ReadLine();
        cronometro.Stop();

        int duracion = (int)cronometro.Elapsed.TotalSeconds;
        Console.WriteLine($"Duración de la llamada: {duracion} segundos");

        if (tipoLlamada == 1)
        {
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8604 // Possible null reference argument.
            llamadas.Add(new LlamadaLocal(numeroOrigen, numeroDestino, duracion));
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning restore CS8604 // Possible null reference argument.
        }
        else if (tipoLlamada == 2)
        {
            Console.Write("Seleccione la franja horaria (1, 2, 3): ");
#pragma warning disable CS8604 // Possible null reference argument.
            int franja = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8604 // Possible null reference argument.
            llamadas.Add(new LlamadaProvincial(numeroOrigen, numeroDestino, duracion, (LlamadaProvincial.FranjaHoraria)franja));
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning restore CS8604 // Possible null reference argument.
        }
    }

    public void MostrarInforme()
    {
        int totalLlamadas = llamadas.Count;
        double totalFacturacion = 0;

        Console.WriteLine("\nResumen de llamadas:");
        foreach (var llamada in llamadas)
        {
            Console.WriteLine($"Llamada desde {llamada.NumeroOrigen} a {llamada.NumeroDestino}, Duración: {llamada.Duracion} segundos, Coste: {llamada.CalcularCoste():C2}");
            totalFacturacion += llamada.CalcularCoste();
        }

        Console.WriteLine($"\nNúmero total de llamadas: {totalLlamadas}");
        Console.WriteLine($"Facturación total: {totalFacturacion:C2}");
    }
}
