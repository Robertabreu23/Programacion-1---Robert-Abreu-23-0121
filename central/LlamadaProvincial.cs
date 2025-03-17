public class LlamadaProvincial : Llamada
{
    public enum FranjaHoraria
    {
        Franja1 = 1, // 20 céntimos
        Franja2 = 2, // 25 céntimos
        Franja3 = 3  // 30 céntimos
    }

    public FranjaHoraria Franja { get; set; }

    public LlamadaProvincial(string numeroOrigen, string numeroDestino, int duracion, FranjaHoraria franja)
        : base(numeroOrigen, numeroDestino, duracion)
    {
        Franja = franja;
    }

    public override double CalcularCoste()
    {
        double tarifa = Franja switch
        {
            FranjaHoraria.Franja1 => 0.20,
            FranjaHoraria.Franja2 => 0.25,
            FranjaHoraria.Franja3 => 0.30,
            _ => 0.20
        };
        return Duracion * tarifa;
    }
}
