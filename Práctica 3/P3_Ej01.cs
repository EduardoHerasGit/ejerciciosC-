using System;

namespace PracticaMetodosYClases
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Ejercicio 1: Suma y Media de un Array ---");
            Console.Write("Introduce el tamaño del array de enteros: ");
            if (!int.TryParse(Console.ReadLine(), out int tamano) || tamano <= 0)
            {
                Console.WriteLine("El tamaño debe ser un entero positivo.");
                return;
            }

            int[] numeros = new int[tamano];
            int suma = 0;

            for (int i = 0; i < tamano; i++)
            {
                Console.Write($"Introduce el valor para el elemento [{i}]: ");
                while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.Write($"Entrada no válida. Reintroduce el valor para [{i}]: ");
                }
                suma += numeros[i];
            }

            double media = (double)suma / tamano;

            Console.WriteLine("
--- Resultados ---");
            Console.WriteLine($"Suma total: {suma}");
            Console.WriteLine($"Media: {media:F2}");
        }
    }
}
