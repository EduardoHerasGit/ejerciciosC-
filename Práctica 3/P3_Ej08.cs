using System;

namespace PracticaMetodosYClases
{
    class Ejercicio8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Ejercicio 8: Suma de Dígitos ---");
            Console.Write("Introduce un número entero: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                int suma = SumarDigitos(numero);
                Console.WriteLine($"La suma de los dígitos de {numero} es: {suma}");
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }

        /// <summary>
        /// Calcula la suma de los dígitos individuales de un número entero.
        /// </summary>
        static int SumarDigitos(int numero)
        {
            int n = Math.Abs(numero);
            int suma = 0;

            while (n > 0)
            {
                suma += n % 10;
                n /= 10;
            }

            return suma;
        }
    }
}
