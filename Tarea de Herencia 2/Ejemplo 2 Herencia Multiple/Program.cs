using System;

interface IVolador
{
    void Volar();
}

interface IAcuatico
{
    void Nadar();
}

class Pato : IVolador, IAcuatico
{
    public void Volar()
    {
        Console.WriteLine("El pato está volando.");
    }

    public void Nadar()
    {
        Console.WriteLine("El pato está nadando.");
    }
}

class Program
{
    static void Main()
    {
        Pato pato = new Pato();
        pato.Volar();
        pato.Nadar();
    }
}

