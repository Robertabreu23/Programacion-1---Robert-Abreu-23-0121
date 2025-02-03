//El patrón Singleton garantiza que una clase tenga una única instancia y proporciona un punto de acceso global a esa instancia. Se usa en configuraciones, conexiones a bases de datos, etc.
using System;

public class Singleton
{
    private static Singleton _instance;
    private static readonly object _lock = new object();

    // Constructor privado evita instanciación externa
    private Singleton() { }

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock) // Hilo seguro
            {
                if (_instance == null)
                    _instance = new Singleton();
            }
        }
        return _instance;
    }

    public void ShowMessage() => Console.WriteLine("Instancia única en acción.");
}

class Program
{
    static void Main()
    {
        Singleton instance1 = Singleton.GetInstance();
        Singleton instance2 = Singleton.GetInstance();

        instance1.ShowMessage();
        
        Console.WriteLine(instance1 == instance2); // True: misma instancia
    }
}
