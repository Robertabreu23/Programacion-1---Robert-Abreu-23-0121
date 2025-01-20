using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número entero de dos dígitos: ");
        int numero;

        
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 10 || numero > 99)
        {
            Console.WriteLine("Por favor, introduce un número válido de dos dígitos.");
        }

        
        int digito1 = numero / 10; 
        int digito2 = numero % 10; 

        
        bool esDigito1Primo = EsPrimo(digito1);
        bool esDigito2Primo = EsPrimo(digito2);

        if (esDigito1Primo && esDigito2Primo)
        {
            Console.WriteLine($"Ambos dígitos del número {numero} son primos.");
        }
        else
        {
            Console.WriteLine($"No ambos dígitos del número {numero} son primos.");
        }
    }

    
    static bool EsPrimo(int numero)
    {
        if (numero < 2) return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) return false;
        }

        return true;
    }
}

