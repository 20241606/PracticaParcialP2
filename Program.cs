using System;

class Program
{
    static void Main(string[] args)
    {
        //Ejercicio 1
        Console.WriteLine("Bienvenidos al grupo Los Elegidos");
        Console.WriteLine();

        // Variables
        int puntos = 100;
        string asignatura = "Programacion";
        double promedio = 89.5;
        bool conectado = false;

        Console.WriteLine("Puntos acumulados: " + puntos);
        Console.WriteLine("Asignatura actual: " + asignatura);
        Console.WriteLine("Promedio del estudiante: " + promedio);
        Console.WriteLine("¿El usuario esta conectado?: " + conectado);
        Console.WriteLine();

        //Ejercicio 2
        // Par o impar
        Console.WriteLine("Ingrese un numero:");
        int numero;

        if (int.TryParse(Console.ReadLine(), out numero))
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
        else
        {
            Console.WriteLine("Eso no es un numero valido");
        }

        Console.WriteLine();

        // Bucle del 1 al 10
        Console.WriteLine("Numeros del 1 al 10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        //Ejercicio 3
        //Creamos el primer objeto de la clase Persona
        Persona persona1 = new Persona();

        //Asignamos el nombre y la edad
        persona1.Nombre = "Carlos";
        persona1.Edad = 20;

        //Creamos el segundo objeto
        Persona persona2 = new Persona();

        //Asignamos sus datos
        persona2.Nombre = "Ana";
        persona2.Edad = 25;

        //Creamos el tercer objeto
        Persona persona3 = new Persona();

        //Asignamos sus datos
        persona3.Nombre = "Pedro";
        persona3.Edad = 22;

        //Llamamos al metodo Presentarse de cada persona
        persona1.Presentarse();
        persona2.Presentarse();
        persona3.Presentarse();

        
        Console.WriteLine();

        //Ejercicio 4

        //Creamos un objeto de la clase Perro
        Perro perro1 = new Perro();

        //Creamos un objeto de la clase Gato
        Gato gato1 = new Gato();

        //Llamamos al metodo hacer sonido del perro
        perro1.HacerSonido();

        //Llamamos al metodo hacer sonido del gato
        gato1.HacerSonido();

        Console.WriteLine();

        //Ejercicio 5

        //Creamos una lista que puede guardar objetos de tipo Animal
        List<Animal> animales = new List<Animal>();

        //Agregamos un perro a la lista
        animales.Add(new Perro());

        //Agregamos un gato a la lista
        animales.Add(new Gato());

        //Recorremos todos los animales que estan en la lista
        foreach (Animal animal in animales)
{
        //Ejecutamos el metodo hacer sonido de cada animal
        //Cada objeto utiliza su propia version del metodo
        animal.HacerSonido();
}

        Console.WriteLine();

        
        //Ejercicio 6

        //Creamos una cuenta bancaria
        CuentaBancaria cuenta = new CuentaBancaria();

        //Depositamos 1500 en la cuenta
        cuenta.Depositar(1500);

        //Mostramos el saldo que devuelve ObtenerSaldo()
        Console.WriteLine("Saldo actual: " + cuenta.ObtenerSaldo());

        Console.WriteLine();

        //Ejercicio 7

        //Creamos un carro y probamos sus metodos
        Carro carro = new Carro();

        carro.Encender();
        carro.Apagar();

        //Creamos una motocicleta y probamos sus metodos
        Motocicleta moto = new Motocicleta();

        moto.Encender();
        moto.Apagar();

        Console.WriteLine();


        Console.ReadKey();
    }
}