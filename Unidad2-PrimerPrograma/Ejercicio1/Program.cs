using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,resultado;

            Console.WriteLine("Ingrese el primer nro: ");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo nro: ");
            n2=int.Parse(Console.ReadLine());

            resultado=n1+n2;

            Console.WriteLine("La suma es: "+resultado);
    
        }
    }
}
