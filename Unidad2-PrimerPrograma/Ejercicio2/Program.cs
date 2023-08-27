using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           int n, resultado;

           Console.WriteLine("Ingrese el nro: ");
           n=int.Parse(Console.ReadLine());

           resultado = n * n * n;

           Console.WriteLine("El resultado de elevar "+n+" al cubo es: "+resultado);

        }
    }
}
