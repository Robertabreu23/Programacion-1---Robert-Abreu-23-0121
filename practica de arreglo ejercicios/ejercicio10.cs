using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int contadorDivisores = 0;

        // Leer 10 números enteros y almacenarlos en el arreglo
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Introduce el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Leer el número a analizar
        Console.Write("\nIntroduce un número adicional: ");
        int numeroAnalizar = int.Parse(Console.ReadLine());

        // Determinar cuántos valores del arreglo son divisores exactos del número ingresado
        foreach (int num in numeros)
        {
            if (num != 0 && numeroAnalizar % num == 0) // Evitar división por cero
            {
                contadorDivisores++;
            }
        }

        // Mostrar el resultado
        Console.WriteLine($"\nEl número {numeroAnalizar} tiene {contadorDivisores} divisores exactos en el arreglo.");
    }
}
