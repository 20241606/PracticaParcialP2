
using System;

// Creamos la clase Perro que hereda de Animal
public class Perro : Animal
{
    // Modificamos el metodo heredado de Animal
    public override void HacerSonido()
    {
        // Mostramos el sonido que hace un perro
        Console.WriteLine("Guau, guau");
    }
}
