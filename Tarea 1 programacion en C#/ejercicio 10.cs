//10. Leer dos números enteros y si la diferencia entre los dos es menor o igual a 10 entonces mostrar en pantalla todos los enteros comprendidos entre el menor y el mayor de los números leídos.
using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer numero");
        int num1=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Ingrese el segundo numero");
        int num2=Convert.ToInt32(Console.ReadLine());
        int diferencia = num1 - num2;
        if(diferencia <= 10)
        {   Console.WriteLine("Estos son los numeros comprendidos entre ambos numeros");
            for(int i =num1; i<=num2;i++)
            {
                Console.WriteLine(i);
            }
        }   
        else
        {
            Console.WriteLine("Estos numeros poseen una diferencia mas alla de 10");
        }    
            
       
            
                    
                
                
    }   


     
}