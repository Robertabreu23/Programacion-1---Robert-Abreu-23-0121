public class LlamadaLocal : Llamada
{
    private const double COSTO_SEGUNDO_LOCAL = 0.15;

    public LlamadaLocal(string numeroOrigen, string numeroDestino, int duracion)
        : base(numeroOrigen, numeroDestino, duracion)
    { }

    public override double CalcularCoste()
    {
        return Duracion * COSTO_SEGUNDO_LOCAL;
    }
}
