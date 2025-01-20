//8.    Leer un número entero de cinco dígitos y determinar si es un número Capicúa. 
using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Ingrese un número de cinco dígitos: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        
        if (numero >= 10000 && numero <= 99999)
        {
            
            string numeroStr = numero.ToString();

            
            if (numeroStr == new string(numeroStr.Reverse().ToArray()))
            {
                Console.WriteLine("El número es Capicúa.");
            }
            else
            {
                Console.WriteLine("El número no es Capicúa.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número de cinco dígitos.");
        }
    }
}
