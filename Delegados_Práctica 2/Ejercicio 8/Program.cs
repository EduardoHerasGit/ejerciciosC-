using System;
using System.Text;

namespace Ejercicio8
{
    // Ejercicio 8: Delegados y retornos condicionales
    internal class Program
    {
        // Acepta un entero y devuelve un entero
        delegate int Transformar(int numero);

        static int Doblar(int numero)
        {
            return numero * 2;
        }

        static int Triplicar(int numero)
        {
            return numero * 3;
        }

        static int Cuadrado(int numero)
        {
            return numero * numero;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int numero = 7;

            Transformar transformaciones = Doblar;
            transformaciones += Triplicar;
            transformaciones += Cuadrado;

            Console.WriteLine($"Número original: {numero}");
            Console.WriteLine();

            // Bucle que aplica cada transformación y muestra el resultado
            foreach (Transformar transformar in transformaciones.GetInvocationList())
            {
                int resultado = transformar(numero);
                Console.WriteLine($"{transformar.Method.Name}({numero}) = {resultado}");
            }
        }
    }
}
