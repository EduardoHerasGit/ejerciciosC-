using System;
using System.Text;

namespace Ejercicio3
{
    // Ejercicio 3: Uso de Multicast Delegates
    internal class Program
    {
        delegate int Operacion(int a, int b);

        static int Sumar(int a, int b)
        {
            Console.WriteLine($"  -> Ejecutando Sumar({a}, {b})");
            return a + b;
        }

        static int Restar(int a, int b)
        {
            Console.WriteLine($"  -> Ejecutando Restar({a}, {b})");
            return a - b;
        }

        static int Multiplicar(int a, int b)
        {
            Console.WriteLine($"  -> Ejecutando Multiplicar({a}, {b})");
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a = 6, b = 3;

            // Delegado multicast: los tres métodos en el mismo delegado
            Operacion operaciones = Sumar;
            operaciones += Restar;
            operaciones += Multiplicar;

            // Una llamada directa ejecuta los tres métodos,
            // pero solo devuelve el resultado del ÚLTIMO.
            Console.WriteLine("Llamada directa al delegado multicast:");
            int ultimo = operaciones(a, b);
            Console.WriteLine($"Valor devuelto (solo el del último método): {ultimo}");

            // Para obtener el resultado de cada uno recorremos su lista de invocación
            Console.WriteLine();
            Console.WriteLine("Resultado de cada método de la lista de invocación:");
            foreach (Operacion o in operaciones.GetInvocationList())
            {
                int resultado = o(a, b);
                Console.WriteLine($"{o.Method.Name}({a}, {b}) = {resultado}");
            }
        }
    }
}
