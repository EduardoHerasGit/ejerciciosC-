using System;

namespace PracticaMetodosYClases
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Ejercicio 2: Contador de Espacios en Blanco ---");
            Console.Write("Introduce una cadena de texto: ");
            string texto = Console.ReadLine();

            int numEspacios = ContarEspacios(texto);
            Console.WriteLine($"Número de espacios en blanco: {numEspacios}");
        }

        /// <summary>
        /// Recibe una cadena de texto y devuelve el número de espacios en blanco.
        /// </summary>
        static int ContarEspacios(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return 0;

            int contador = 0;
            foreach (char c in texto)
            {
                if (c == ' ')
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
