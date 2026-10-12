

using System;

// Creamos una clase llamada Persona
public class Persona
{
    // Propiedad para guardar el nombre de la persona
    public string Nombre { get; set; } = "";

    // Propiedad para guardar la edad de la persona
    public int Edad { get; set; }

    // Metodo que muestra la informacion de la persona
    public void Presentarse()
    {
        // Imprimimos el nombre y la edad
        Console.WriteLine("Hola, mi nombre es " + Nombre +
                          " y tengo " + Edad + " años.");
    }
}
