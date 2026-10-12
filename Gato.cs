
using System;

// Creamos la clase Gato que hereda de Animal
public class Gato : Animal
{
    // Modificamos el metodo heredado de Animal
    public override void HacerSonido()
    {
        // Mostramos el sonido que hace un gato
        Console.WriteLine("Miau");
    }
}
