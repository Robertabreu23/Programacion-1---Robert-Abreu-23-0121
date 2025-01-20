internal class Program
{//9.    Leer un número entero de cuatro dígitos y determinar si el segundo dígito es igual al penúltimo.
    private static void Main(string[] args)
    {
        Console.WriteLine("Escribe un numero de 4 digitos");
        int numero =Convert.ToInt32(Console.ReadLine());
        if(numero>999 && numero<=9999)
        {
            Console.WriteLine("Bien este es un numero de 4 digitos continuemos");

        }
        else
        {
            Console.WriteLine("Este no es un numero de 4 digitos");
            return;
        }

       
        int digit2= (numero %1000)/100;
        int digit3= (numero%100)/10;
        Console.WriteLine("Este es el segundo digito " + digit2);
        Console.WriteLine("Este es el penultimo digito " + digit3);



        if(digit2== digit3)
        {
            Console.WriteLine("Si son iguales");
           
            

        

        }
        else
        {
            Console.WriteLine("No son iguales");
            
        }

    }
}