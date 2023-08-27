using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,resultado;

            Console.WriteLine("Ingrese en kms la distancia entre ciudades: ");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("A que velocidad circula: ");
            n2=int.Parse(Console.ReadLine());

            resultado = n1/n2;

            Console.WriteLine("El viaje sera de: "+resultado+" horas.");
        }
    }
}
