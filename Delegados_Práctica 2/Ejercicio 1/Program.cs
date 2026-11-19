using System;
using System.Text;

namespace Ejercicio1
{
    // Ejercicio 1: Delegado básico
    internal class Program
    {
        // Delegado que acepta dos enteros y devuelve un entero
        delegate int Operacion(int a, int b);

        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Operacion operacion = Sumar;

            int a = 8, b = 5;
            int resultado = operacion(a, b);

            Console.WriteLine($"Sumar({a}, {b}) = {resultado}");
        }
    }
}
