using System;
using System.Numerics; // Para manejar números grandes con BigInteger

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        BigInteger[] factoriales = new BigInteger[10];

        // Leer 10 números enteros
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Introduce el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            // Calcular el factorial y almacenarlo
            factoriales[i] = CalcularFactorial(numeros[i]);
        }

        // Mostrar los resultados
        Console.WriteLine("\nFactoriales:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Factorial de {numeros[i]} = {factoriales[i]}");
        }
    }

    // Función para calcular el factorial de un número
    static BigInteger CalcularFactorial(int num)
    {
        if (num < 0) return -1; // Factorial de números negativos no está definido
        BigInteger resultado = 1;
        for (int i = 2; i <= num; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}
