using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(String[] args)
    {
        //Verificar si un ano es bisiesto
        Console.WriteLine("Veamos si este ano es bisiesto");
        int anoentrada = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine(imprimir(anoentrada));
   
    }

    private static string imprimir( int anoentrada){
     if( anoentrada % 4 ==0  && anoentrada %100==0 && anoentrada %400==0)

        {
             
             return "Es bisiesto";
        }
      
           return "No es bisiesto";
      
    }
}
