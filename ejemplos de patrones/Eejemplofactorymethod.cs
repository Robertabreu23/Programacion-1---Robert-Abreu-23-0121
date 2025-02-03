//El Factory Method define una interfaz para la creación de objetos, pero permite a las subclases alterar el tipo de objeto que se creará. Es útil cuando queremos delegar la creación de objetos a subclases.



using System;

// Interfaz Producto
public interface IVehiculo
{
    void Conducir();
}

// Implementaciones concretas
public class Coche : IVehiculo
{
    public void Conducir() => Console.WriteLine("Conduciendo un coche.");
}

public class Moto : IVehiculo
{
    public void Conducir() => Console.WriteLine("Conduciendo una moto.");
}

// Factory Method
public abstract class VehiculoFactory
{
    public abstract IVehiculo CrearVehiculo();
}

// Fábricas concretas
public class CocheFactory : VehiculoFactory
{
    public override IVehiculo CrearVehiculo() => new Coche();
}

public class MotoFactory : VehiculoFactory
{
    public override IVehiculo CrearVehiculo() => new Moto();
}

// Cliente
class Program
{
    static void Main()
    {
        VehiculoFactory factory1 = new CocheFactory();
        IVehiculo vehiculo1 = factory1.CrearVehiculo();
        vehiculo1.Conducir();

        VehiculoFactory factory2 = new MotoFactory();
        IVehiculo vehiculo2 = factory2.CrearVehiculo();
        vehiculo2.Conducir();
    }
}
