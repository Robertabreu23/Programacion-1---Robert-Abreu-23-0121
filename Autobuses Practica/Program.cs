using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear Autobuses
        Autobus autobus1 = new Autobus("Auto Bus Platinum", 20, 1000);
        Autobus autobus2 = new Autobus("Auto Bus Gold", 15, 1000);

        // Crear Pasajeros y vender boletos
        autobus1.VenderPasaje(new Pasajero("Juan", "Ruta A"));
        autobus1.VenderPasaje(new Pasajero("Pedro", "Ruta A"));
        autobus1.VenderPasaje(new Pasajero("Maria", "Ruta A"));
        autobus1.VenderPasaje(new Pasajero("Ana", "Ruta A"));
        autobus1.VenderPasaje(new Pasajero("Luis", "Ruta A"));

        autobus2.VenderPasaje(new Pasajero("Carlos", "Ruta B"));
        autobus2.VenderPasaje(new Pasajero("Elena", "Ruta B"));
        autobus2.VenderPasaje(new Pasajero("David", "Ruta B"));

        // Mostrar estado de los autobuses
        autobus1.MostrarEstado();
        autobus2.MostrarEstado();
    }
}
