class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int mayorPar = int.MinValue;
        int posicionMayorPar = -1;

        // Leer 10 números enteros
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Introduce el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            // Verificar si el número es par y si es el mayor hasta ahora
            if (numeros[i] % 2 == 0 && numeros[i] > mayorPar)
            {
                mayorPar = numeros[i];
                posicionMayorPar = i;
            }
        }

        // Mostrar el resultado
        if (posicionMayorPar != -1)
        {
            Console.WriteLine($"El mayor número par es {mayorPar} y está en la posición {posicionMayorPar + 1}");
        }
        else
        {
            Console.WriteLine("No se ingresaron números pares.");
        }
    }
}
