
using System;

// Clase Motocicleta que implementa IVehiculo
public class Motocicleta : IVehiculo
{
    // Metodo para encender la motocicleta
    public void Encender()
    {
        Console.WriteLine("La motocicleta está encendida.");
    }

    // Metodo para apagar la motocicleta
    public void Apagar()
    {
        Console.WriteLine("La motocicleta está apagada.");
    }
}
