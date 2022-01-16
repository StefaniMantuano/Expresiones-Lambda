using System;
using System.Collections.Generic;
using System.Linq;

namespace EjemploLambda
{

    class Program
    {
        static void Main(String[] args)
        {
            Func<int, int> potencia = x => x * x;
            Console.WriteLine("El resultado es: " + Convert.ToInt32(potencia(5)));
            Console.WriteLine("El resultado método: " + Convert.ToInt32(metodoPotencia(9)));

            Func<int, int, int> resta = (x,y) => x - y;
            Console.WriteLine("El resultado de la resta es: " + Convert.ToInt32(resta(14, 8)));

            int[] arrayNumeros = { 2, 4, 6, 8, 24, 28, 30, 31, 32, };
            var NumeroalCuadrado = arrayNumeros.Select(x => x * x);
            Console.WriteLine("Resultado: ");
            foreach (int x in NumeroalCuadrado)
                Console.WriteLine(x);

            static int metodoPotencia (int x)
            {
                return x * x;   
            }

        }
    }
}
