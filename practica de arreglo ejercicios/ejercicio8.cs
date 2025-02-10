using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int contadorNegativos = 0;

        // Leer 10 números enteros
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Introduce el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            // Verificar si el número es negativo
            if (numeros[i] < 0)
            {
                contadorNegativos++;
            }
        }

        // Mostrar el resultado
        Console.WriteLine($"Cantidad de números negativos: {contadorNegativos}");
    }
}
