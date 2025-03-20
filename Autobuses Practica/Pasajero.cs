public class Pasajero
{
    public string Nombre { get; set; }
    public string Ruta { get; set; }

    public Pasajero(string nombre, string ruta)
    {
        Nombre = nombre;
        Ruta = ruta;
    }
}
