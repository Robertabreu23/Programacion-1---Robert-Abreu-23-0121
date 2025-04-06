using System;

class Program
{
    static void Main()
    {
        // Hamburguesa clásica
        Hamburguesa clasica = new Hamburguesa("Pan blanco", "Carne de res", 5.0);
        clasica.AgregarAdicional("Lechuga", 0.5);
        clasica.AgregarAdicional("Tomate", 0.4);
        clasica.AgregarAdicional("Queso", 0.8);
        clasica.AgregarAdicional("Pepinillo", 0.6);
        clasica.MostrarFactura();

        // Hamburguesa saludable
        HamburguesaSaludable saludable = new HamburguesaSaludable("Carne de pollo", 6.0);
        saludable.AgregarAdicional("Aguacate", 1.0);
        saludable.AgregarAdicional("Espinaca", 0.6);
        saludable.AgregarAdicional("Tomate", 0.4);
        saludable.AgregarAdicional("Queso bajo en grasa", 0.7);
        saludable.MostrarFactura();

        // Hamburguesa premium
        HamburguesaPremium premium = new HamburguesaPremium("Pan brioche", "Doble carne", 7.5);
        premium.AgregarAdicional("Tocino", 1.0);  // No debería permitirlo
        premium.MostrarFactura();
    }
}
