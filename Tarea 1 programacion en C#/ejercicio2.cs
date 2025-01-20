// Leer un número entero de dos dígitos y determinar si es primo y además si es negativo.
 Console.WriteLine("Ingrese un número:");
 int numero = Convert.ToInt32(Console.ReadLine());
 if (numero < 0)
    {
            Console.WriteLine($"{numero} es un número negativo.");
     }
else
     {
            Console.WriteLine(EsPrimo(numero) ? $"{numero} es primo." : $"{numero} no es primo.");
     }


    static bool EsPrimo(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }
