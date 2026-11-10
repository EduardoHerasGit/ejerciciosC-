using System;

namespace PracticaMetodosYClases
{
    class Ejercicio7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Ejercicio 7: Comprobación de Múltiplos ---");
            
            Console.Write("Introduce el primer número entero: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número entero: ");
            int n2 = int.Parse(Console.ReadLine());

            bool primeroEsMultiplo = EsMultiplo(n1, n2);
            bool segundoEsMultiplo = EsMultiplo(n2, n1);

            if (primeroEsMultiplo)
            {
                Console.WriteLine($"{n1} es múltiplo de {n2}.");
            }

            if (segundoEsMultiplo)
            {
                Console.WriteLine($"{n2} es múltiplo de {n1}.");
            }

            if (!primeroEsMultiplo && !segundoEsMultiplo)
            {
                Console.WriteLine("Ninguno de los dos números es múltiplo del otro.");
            }
        }

        /// <summary>
        /// Devuelve true si el primer número es múltiplo del segundo.
        /// </summary>
        static bool EsMultiplo(int num1, int num2)
        {
            if (num2 == 0) return false;
            return num1 % num2 == 0;
        }
    }
}
