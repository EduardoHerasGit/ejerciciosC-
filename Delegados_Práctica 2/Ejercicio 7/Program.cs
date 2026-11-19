using System;
using System.Text;

namespace Ejercicio7
{
    // Ejercicio 7: Delegados y arrays
    // (el método Restar queda descartado en este ejercicio)
    internal class Program
    {
        // Ahora el delegado recibe un array de enteros y devuelve un entero
        delegate int Operar(int[] numeros);

        // Devuelve la suma de todos los elementos del array
        static int Suma(int[] numeros)
        {
            int total = 0;

            foreach (int n in numeros)
            {
                total += n;
            }

            return total;
        }

        // Devuelve la multiplicación de todos los elementos del array
        static int Multiplicar(int[] numeros)
        {
            int total = 1;

            foreach (int n in numeros)
            {
                total *= n;
            }

            return total;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] numeros = { 2, 3, 4, 5 };

            Console.WriteLine("Array: [" + string.Join(", ", numeros) + "]");
            Console.WriteLine();

            Operar operaciones = Suma;
            operaciones += Multiplicar;

            foreach (Operar operacion in operaciones.GetInvocationList())
            {
                int resultado = operacion(numeros);
                Console.WriteLine($"{operacion.Method.Name} = {resultado}");
            }
        }
    }
}
