using System;

class Persona
{
    public required string Nombre { get; set; }
    public int Edad { get; set; }

    public void MostrarPersona()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    }
}

class Empleado : Persona
{
    public required string Cargo { get; set; }

    public void MostrarEmpleado()
    {
        MostrarPersona();
        Console.WriteLine($"Cargo: {Cargo}");
    }
}

class Gerente : Empleado
{
    public required string Departamento { get; set; }

    public void MostrarGerente()
    {
        MostrarEmpleado();
        Console.WriteLine($"Departamento: {Departamento}");
    }
}

class Program
{
    static void Main()
    {
        Gerente gerente = new Gerente { Nombre = "Carlos", Edad = 40, Cargo = "Gerente General", Departamento = "Ventas" };
        gerente.MostrarGerente();
    }
}
