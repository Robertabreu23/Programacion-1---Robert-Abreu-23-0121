using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int suma = 0;

        // Leer 10 números enteros
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Introduce el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
            suma += numeros[i]; // Sumar los números
        }

        // Calcular el promedio entero
        int promedio = suma / 10;

        // Mostrar el resultado
        Console.WriteLine($"El promedio entero de los datos es: {promedio}");
    }
}
