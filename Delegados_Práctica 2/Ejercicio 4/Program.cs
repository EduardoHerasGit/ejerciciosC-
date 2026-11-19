using System;
using System.Text;

namespace Ejercicio4
{
    // Ejercicio 4: Delegados con diferentes métodos (incluye división por cero)
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

        static int Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero.");
            }

            return a / b;
        }

        // Llama a todos los métodos del delegado, uno a uno, controlando los errores
        static void EjecutarTodos(Operacion operaciones, int a, int b)
        {
            Console.WriteLine($"--- Operaciones con a = {a} y b = {b} ---");

            foreach (Operacion o in operaciones.GetInvocationList())
            {
                try
                {
                    int resultado = o(a, b);
                    Console.WriteLine($"{o.Method.Name}({a}, {b}) = {resultado}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"{o.Method.Name}({a}, {b}) -> Error: {ex.Message}");
                }
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Operacion operaciones = Sumar;
            operaciones += Restar;
            operaciones += Multiplicar;
            operaciones += Dividir;

            // Caso normal
            EjecutarTodos(operaciones, 20, 4);

            // Caso con división por cero
            EjecutarTodos(operaciones, 20, 0);
        }
    }
}
