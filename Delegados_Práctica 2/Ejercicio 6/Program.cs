using System;
using System.Text;

namespace Ejercicio6
{
    // Ejercicio 6: Delegados y nombres
    internal class Program
    {
        delegate int Operar(int a, int b);

        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a = 9, b = 7;

            // Asignamos los tres métodos al mismo delegado
            Operar operaciones = Suma;
            operaciones += Resta;
            operaciones += Multiplicacion;

            // Bucle que llama a cada método mostrando su nombre y su resultado
            foreach (Operar operacion in operaciones.GetInvocationList())
            {
                int resultado = operacion(a, b);
                Console.WriteLine($"{operacion.Method.Name}({a}, {b}) = {resultado}");
            }
        }
    }
}
