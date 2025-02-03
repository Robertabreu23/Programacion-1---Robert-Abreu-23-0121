//El patrón Observer define una relación de dependencia uno-a-muchos, donde varios objetos dependen de otro y se actualizan automáticamente cuando el estado cambia.
using System;
using System.Collections.Generic;

// Interfaz del observador
public interface IObserver
{
    void Update(string message);
}

// Sujeto (publicador)
public class Notificador
{
    private List<IObserver> _observadores = new List<IObserver>();

    public void Suscribir(IObserver observador) => _observadores.Add(observador);
    public void Desuscribir(IObserver observador) => _observadores.Remove(observador);

    public void Notificar(string message)
    {
        foreach (var observador in _observadores)
        {
            observador.Update(message);
        }
    }
}

// Observador concreto
public class Usuario : IObserver
{
    private string _nombre;
    public Usuario(string nombre) => _nombre = nombre;

    public void Update(string message) => Console.WriteLine($"{_nombre} recibió notificación: {message}");
}

// Cliente
class Program
{
    static void Main()
    {
        Notificador notificador = new Notificador();

        Usuario usuario1 = new Usuario("Robert");
        Usuario usuario2 = new Usuario("Carlos");

        notificador.Suscribir(usuario1);
        notificador.Suscribir(usuario2);

        notificador.Notificar("Nueva oferta de descuento!");
        
        notificador.Desuscribir(usuario1);
        
        notificador.Notificar("Actualización de seguridad disponible.");
    }
}
