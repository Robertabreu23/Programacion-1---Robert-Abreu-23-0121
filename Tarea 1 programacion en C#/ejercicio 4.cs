internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Determinemos si la suma de dos numeros de dos digitos ingresados es par");
        Console.WriteLine("Ingrese tu primer numero de dos digitos");
        int num1 = Convert.ToInt32(Console.ReadLine());
     if (num1 > 10 && num1 < 99) 
        {
            Console.WriteLine("Perfecto ahora continuemos");
        }

    else
        {
            Console.WriteLine("No es un numero de dos digitos");
            return;
        }
        Console.WriteLine("Ingresa el segundo numero de dos digitos");
        int num2 = Convert.ToInt32(Console.ReadLine());
     if (num2 > 10 && num2 < 99) 
        {
            Console.WriteLine("ahora vamos a sumarlo y determinar si es par");
        }

    else
        {
            Console.WriteLine("No es un numero de dos digitos");
            return;
        }
        int numero = num1 + num2;
        if (numero % 2 == 0)
{
    Console.WriteLine("Tu numero es" + numero);
    Console.WriteLine("El número  es par.");

}
else
{
     Console.WriteLine("Tu numero es" + numero);
    Console.WriteLine("El número es impar.");
}

}   }