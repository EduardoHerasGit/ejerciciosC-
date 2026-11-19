using System;
using System.Text;

namespace Ejercicio5
{
    // Ejercicio 5: Delegados y retornos
    internal class Program
    {
        delegate int Operacion(int a, int b);

        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static int Restar(int a, int b)
        {
            return a - b;
        }

        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        // Recibe un delegado y dos enteros, llama al delegado e imprime el resultado
        static void EjecutarOperacion(Operacion operacion, int a, int b)
        {
            int resultado = operacion(a, b);
            Console.WriteLine($"{operacion.Method.Name}({a}, {b}) = {resultado}");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a = 12, b = 3;

            EjecutarOperacion(Sumar, a, b);
            EjecutarOperacion(Restar, a, b);
            EjecutarOperacion(Multiplicar, a, b);
        }
    }
}
