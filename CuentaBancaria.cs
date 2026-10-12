
using System;


// Ejercicio 6
public class CuentaBancaria
{
    // Atributo privado que guarda el saldo
    private decimal saldo = 0;

    // Metodo para agregar dinero a la cuenta
    public void Depositar(decimal monto)
    {
        saldo += monto;
    }

    // Metodo que devuelve el saldo actual
    public decimal ObtenerSaldo()
    {
        return saldo;
    }
}
