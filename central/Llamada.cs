using System;

public abstract class Llamada
{
    public string NumeroOrigen { get; set; }
    public string NumeroDestino { get; set; }
    public int Duracion { get; set; }

    public Llamada(string numeroOrigen, string numeroDestino, int duracion)
    {
        NumeroOrigen = numeroOrigen;
        NumeroDestino = numeroDestino;
        Duracion = duracion;
    }

    public abstract double CalcularCoste();
}
