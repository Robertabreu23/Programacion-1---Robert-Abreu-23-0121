//7.Leer tres números enteros y determinar cuál es el mayor. Usar solamente dos variables.
internal class Program
{
    private static void Main(string[] args)
    {
       
        Console.WriteLine("ingrese el primer numero");
        int mayor = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Ingrese el segundo numero");
        int actual = Convert.ToInt32(Console.ReadLine());
        if(actual>mayor)
        {
          
            mayor=actual;
        }
        Console.WriteLine("Ingrese el tercer numero");
        actual = Convert.ToInt32(Console.ReadLine());
        if(actual>mayor)
        {
             mayor=actual;
            
        }
        Console.WriteLine("Este es el mayor " + mayor);
        
    }
}