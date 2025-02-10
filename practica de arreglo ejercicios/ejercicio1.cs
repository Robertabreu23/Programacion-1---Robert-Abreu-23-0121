class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int mayorNumero = int.MinValue;
        int posicionMayor = -1;

        // Leer 10 números enteros
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Introduce el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            // Verificar si el número actual es el mayor
            if (numeros[i] > mayorNumero)
            {
                mayorNumero = numeros[i];
                posicionMayor = i;
            }
        }

        // Mostrar el resultado
        Console.WriteLine($"El mayor número es {mayorNumero} y está en la posición {posicionMayor + 1}");
    }
}
