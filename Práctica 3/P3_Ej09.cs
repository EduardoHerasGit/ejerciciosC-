using System;

namespace PracticaMetodosYClases
{
    class Ejercicio9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Ejercicio 9: Posición del Menor en un Array ---");
            
            // Array definido directamente en el código
            int[] numeros = { 45, 12, 89, 7, 23, 7, 56 };

            Console.WriteLine("Valores del array: [" + string.Join(", ", numeros) + "]");

            int posMenor = PosicionMenor(numeros);

            if (posMenor != -1)
            {
                Console.WriteLine($"El número menor es {numeros[posMenor]} y se encuentra en la posición (índice) {posMenor}.");
            }
            else
            {
                Console.WriteLine("El array está vacío.");
            }
        }

        /// <summary>
        /// Devuelve el índice de la primera ocurrencia del valor menor en el array.
        /// </summary>
        static int PosicionMenor(int[] array)
        {
            if (array == null || array.Length == 0) return -1;

            int posMenor = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[posMenor])
                {
                    posMenor = i;
                }
            }
            return posMenor;
        }
    }
}
