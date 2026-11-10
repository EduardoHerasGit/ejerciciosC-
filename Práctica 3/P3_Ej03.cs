using System;

namespace PracticaMetodosYClases
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Ejercicio 3: Factorial Recursivo ---");
            Console.Write("Introduce un número entero no negativo: ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
            {
                long factorial = CalcularFactorial(numero);
                Console.WriteLine($"El factorial de {numero}! es: {factorial}");
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número entero válido mayor o igual a 0.");
            }
        }

        /// <summary>
        /// Calcula el factorial de n de forma recursiva.
        /// </summary>
        static long CalcularFactorial(int n)
        {
            if (n <= 1)
                return 1;
            return n * CalcularFactorial(n - 1);
        }
    }
}
