
using System;

// Creamos la clase principal llamada Animal
public class Animal
{
    // Metodo que puede ser modificado por las clases hijas
    public virtual void HacerSonido()
    {
        // Mensaje general de un animal
        Console.WriteLine("El animal hace un sonido.");
    }
}
