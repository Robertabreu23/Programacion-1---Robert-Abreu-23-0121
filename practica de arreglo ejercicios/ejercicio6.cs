using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        string posiciones = "";

        // Leer 10 números enteros
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Introduce el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            // Verificar si el número tiene más de 3 dígitos
            if (ContarDigitos(numeros[i]) > 3)
            {
                posiciones += (i + 1) + " ";
            }
        }

        // Mostrar el resultado
        if (!string.IsNullOrEmpty(posiciones))
        {
            Console.WriteLine($"Los números con más de 3 dígitos están en las posiciones: {posiciones}");
        }
        else
        {
            Console.WriteLine("No se ingresaron números con más de 3 dígitos.");
        }
    }

    // Función para contar los dígitos de un número
    static int ContarDigitos(int numero)
    {
        return numero.ToString().Trim('-').Length;
    }
}
