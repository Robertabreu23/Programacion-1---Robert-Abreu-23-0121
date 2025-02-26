using System;

public class Motor
{
    private int litros_de_aceite;
    private int potencia;

    // Constructor
    public Motor(int potencia)
    {
        this.potencia = potencia;
        this.litros_de_aceite = 0; // Valor por defecto
    }

    // Getters
    public int GetLitrosDeAceite()
    {
        return litros_de_aceite;
    }

    public int GetPotencia()
    {
        return potencia;
    }

    // Setters
    public void SetLitrosDeAceite(int litros)
    {
        litros_de_aceite = litros;
    }

    public void SetPotencia(int potencia)
    {
        this.potencia = potencia;
    }
}

public class Coche
{
    private Motor motor;
    private string marca;
    private string modelo;
    private double precio_averias;

    // Constructor
    public Coche(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.motor = new Motor(100); // Asumimos una potencia por defecto de 100
        this.precio_averias = 0.0;
    }

    // Getters
    public Motor GetMotor()
    {
        return motor;
    }

    public string GetMarca()
    {
        return marca;
    }

    public string GetModelo()
    {
        return modelo;
    }

    public double GetPrecioAverias()
    {
        return precio_averias;
    }

    // Método para acumular averías
    public void AcumularAveria()
    {
        precio_averias += Math.Round(new Random().NextDouble() * 100, 2); // Genera un número aleatorio entre 0 y 100
    }
}

public class Garaje
{
    private Coche cocheAtendido;
    private string averia;
    private int cochesAtendidos;

    public Garaje()
    {
        cocheAtendido = null;
        averia = "";
        cochesAtendidos = 0;
    }

    // Método para aceptar coche
    public bool AceptarCoche(Coche coche, string averia)
    {
        if (cocheAtendido == null) // Si no se está atendiendo a ningún coche
        {
            cocheAtendido = coche;
            this.averia = averia;
            cochesAtendidos++;
            return true;
        }
        return false;
    }

    // Método para devolver coche
    public void DevolverCoche()
    {
        if (cocheAtendido != null)
        {
            if (averia == "aceite")
            {
                cocheAtendido.GetMotor().SetLitrosDeAceite(cocheAtendido.GetMotor().GetLitrosDeAceite() + 10); // Incrementa los litros de aceite
            }
            cocheAtendido = null; // Liberar el coche atendido
        }
    }

    public int GetCochesAtendidos()
    {
        return cochesAtendidos;
    }
}

public class PracticaPOO
{
    public static void Main(string[] args)
    {
        // Crear garaje
        Garaje garaje = new Garaje();

        // Crear coches
        Coche coche1 = new Coche("Toyota", "Corolla");
        Coche coche2 = new Coche("Honda", "Civic");

        // Simular la entrada y salida de coches en el garaje
        for (int i = 0; i < 2; i++)
        {
            // Atender coche 1
            if (garaje.AceptarCoche(coche1, "aceite"))
            {
                coche1.AcumularAveria();
                garaje.DevolverCoche();
            }

            // Atender coche 2
            if (garaje.AceptarCoche(coche2, "aceite"))
            {
                coche2.AcumularAveria();
                garaje.DevolverCoche();
            }
        }

        // Mostrar información de los coches
        Console.WriteLine($"Coche 1: {coche1.GetMarca()} {coche1.GetModelo()} - Litros de Aceite: {coche1.GetMotor().GetLitrosDeAceite()} - Precio de Averías: {coche1.GetPrecioAverias()}");
        Console.WriteLine($"Coche 2: {coche2.GetMarca()} {coche2.GetModelo()} - Litros de Aceite: {coche2.GetMotor().GetLitrosDeAceite()} - Precio de Averías: {coche2.GetPrecioAverias()}");
        Console.WriteLine($"Coches atendidos por el garaje: {garaje.GetCochesAtendidos()}");
    }
}
