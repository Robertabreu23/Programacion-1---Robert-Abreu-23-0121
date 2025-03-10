using System;

class Program
{
    static void Main(string[] args)
    {
        // Creando objetos de las clases derivadas
        Ave aguila = new Aguila("Águila Real", 5);
        Ave pinguino = new Pinguino("Pinguino Emperador", 3);
        Ave paloma = new Paloma("Paloma Mensajera", 2);

        // Usando métodos polimórficos
        aguila.HacerSonido();
        aguila.Volar();
        aguila.Comer();

        pinguino.HacerSonido();
        pinguino.Volar();
        pinguino.Comer();

        paloma.HacerSonido();
        paloma.Volar();
        paloma.Comer();
    }
}
