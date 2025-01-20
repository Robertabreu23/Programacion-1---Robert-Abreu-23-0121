using System;

void funcion(int ejercicio){
    if (ejercicio == 1) { 

    }
}

funcion(1)

internal class Program
{
    private static void Main(string[] args)
    {
        bool numeroValido = false; // Variable de control para el bucle
        
        while (!numeroValido) // Repite mientras el número no sea válido
        {
            Console.WriteLine("Ingrese un número de 3 dígitos:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 99 && num < 1000)
            {
                numeroValido = true; // Número válido, salimos del bucle
                Console.WriteLine("¡Excelente! Ahora vamos a determinar qué dígito es mayor.");
                
                // Cálculo de los dígitos
                int digit1 = num / 100;
                int digit2 = (num / 10) % 10;
                int digit3 = num % 10;

                // Determinar el dígito mayor
                if (digit1 > digit2 && digit1 > digit3)
                {
                    Console.WriteLine(digit1 + " es el mayor dígito, el primero.");
                }
                else if (digit2 > digit1 && digit2 > digit3)
                {
                    Console.WriteLine(digit2 + " es el mayor dígito, el segundo.");
                }
                else
                {
                    Console.WriteLine(digit3 + " es el mayor dígito, el tercero.");
                }
            }
            else
            {
                Console.WriteLine("Este no es un número de 3 dígitos. Inténtalo de nuevo.");
            }
        }
    }
}
