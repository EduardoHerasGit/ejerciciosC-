using System;
using System.Text;

namespace Ejercicio9
{
    // Ejercicio 9: Delegados y funciones de callback
    internal class Program
    {
        delegate int OperacionCallback(int a, int b);

        // Recibe un delegado (callback) y dos enteros,
        // realiza la operación con el delegado y devuelve el resultado
        static int EjecutarOperacion(OperacionCallback callback, int a, int b)
        {
            return callback(a, b);
        }

        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a = 15, b = 5;

            int resultadoSuma = EjecutarOperacion(Suma, a, b);
            Console.WriteLine($"Suma({a}, {b}) = {resultadoSuma}");

            int resultadoResta = EjecutarOperacion(Resta, a, b);
            Console.WriteLine($"Resta({a}, {b}) = {resultadoResta}");

            int resultadoMultiplicacion = EjecutarOperacion(Multiplicar, a, b);
            Console.WriteLine($"Multiplicar({a}, {b}) = {resultadoMultiplicacion}");
        }
    }
}
