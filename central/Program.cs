using System;

public class Program
{
    public static void Main(string[] args)
    {
        Centralita centralita = new Centralita();
        
        Console.WriteLine("Bienvenido a la Centralita Telefónica");
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n1. Realizar una llamada");
            Console.WriteLine("2. Mostrar informe de llamadas");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
#pragma warning disable CS8604 // Possible null reference argument.
            int opcion = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            switch (opcion)
            {
                case 1:
                    centralita.RegistrarLlamadaInteractiva();
                    break;
                case 2:
                    centralita.MostrarInforme();
                    break;
                case 3:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
