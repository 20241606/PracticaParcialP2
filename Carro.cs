
using System;

// Clase Carro que implementa la interfaz IVehiculo
public class Carro : IVehiculo
{
    // Metodo para encender el carro
    public void Encender()
    {
        Console.WriteLine("El carro está encendido.");
    }

    // Metodo para apagar el carro
    public void Apagar()
    {
        Console.WriteLine("El carro está apagado.");
    }
}
