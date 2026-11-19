using System;
using System.Text;

namespace Ejercicio2
{
    // Ejercicio 2: Múltiples métodos
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

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a = 10, b = 4;

            // Asignamos cada método al delegado y lo llamamos
            Operacion operacion = Sumar;
            Console.WriteLine($"Sumar({a}, {b}) = {operacion(a, b)}");

            operacion = Restar;
            Console.WriteLine($"Restar({a}, {b}) = {operacion(a, b)}");

            // Asignamos AMBOS métodos al mismo delegado (multicast)
            // y llamamos a cada uno de ellos de la lista de invocación
            Operacion ambos = Sumar;
            ambos += Restar;

            Console.WriteLine();
            Console.WriteLine("Llamando a cada método del delegado con ambos métodos:");
            foreach (Operacion o in ambos.GetInvocationList())
            {
                Console.WriteLine($"{o.Method.Name}({a}, {b}) = {o(a, b)}");
            }
        }
    }
}
