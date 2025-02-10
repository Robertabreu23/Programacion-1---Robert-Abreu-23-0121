using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int mayorPrimo = int.MinValue;
        int posicionMayorPrimo = -1;

        // Leer 10 números enteros
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Introduce el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            // Verificar si el número es primo y si es el mayor hasta ahora
            if (EsPrimo(numeros[i]) && numeros[i] > mayorPrimo)
            {
                mayorPrimo = numeros[i];
                posicionMayorPrimo = i;
            }
        }

        // Mostrar el resultado
        if (posicionMayorPrimo != -1)
        {
            Console.WriteLine($"El mayor número primo es {mayorPrimo} y está en la posición {posicionMayorPrimo + 1}");
        }
        else
        {
            Console.WriteLine("No se ingresaron números primos.");
        }
    }

    // Función para determinar si un número es primo
    static bool EsPrimo(int numero)
    {
        if (numero < 2)
            return false;
        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
                return false;
        }
        return true;
    }
}
