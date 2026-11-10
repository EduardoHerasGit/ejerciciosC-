using System;

namespace PracticaMetodosYClases
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Ejercicio 4: Comprobación de Número Primo ---");
            Console.Write("Introduce un número entero: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (EsPrimo(numero))
                {
                    Console.WriteLine($"El número {numero} ES primo.");
                }
                else
                {
                    Console.WriteLine($"El número {numero} NO es primo.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }

        /// <summary>
        /// Comprueba si un número es primo.
        /// </summary>
        static bool EsPrimo(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            int limite = (int)Math.Sqrt(n);
            for (int i = 3; i <= limite; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
