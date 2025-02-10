using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int mayorPrimo = -1;
        int maxDigitosPares = -1;
        int posicionMayorPrimo = -1;

        // Leer 10 números enteros
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Introduce el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            // Verificar si el número es primo
            if (EsPrimo(numeros[i]))
            {
                // Contar los dígitos pares del número primo
                int digitosPares = ContarDigitosPares(numeros[i]);

                // Verificar si es el primo con más dígitos pares
                if (digitosPares > maxDigitosPares)
                {
                    maxDigitosPares = digitosPares;
                    mayorPrimo = numeros[i];
                    posicionMayorPrimo = i;
                }
            }
        }

        // Mostrar el resultado
        if (posicionMayorPrimo != -1)
        {
            Console.WriteLine($"El número primo con más dígitos pares es {mayorPrimo} y está en la posición {posicionMayorPrimo + 1}");
        }
        else
        {
            Console.WriteLine("No se ingresaron números primos.");
        }
    }

    // Función para verificar si un número es primo
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

    // Función para contar los dígitos pares de un número
    static int ContarDigitosPares(int numero)
    {
        int contador = 0;
        numero = Math.Abs(numero); // Asegurar que el número es positivo

        while (numero > 0)
        {
            int digito = numero % 10;
            if (digito % 2 == 0) // Verificar si el dígito es par
            {
                contador++;
            }
            numero /= 10;
        }
        return contador;
    }
}
