using System;

namespace PracticaMetodosYClases
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Ejercicio 5: Cálculo de Potencia (Iterativo y Recursivo) ---");
            
            Console.Write("Introduce la base (número entero o decimal): ");
            if (!double.TryParse(Console.ReadLine(), out double baseNum))
            {
                Console.WriteLine("Base no válida.");
                return;
            }

            Console.Write("Introduce el exponente (entero no negativo): ");
            if (!int.TryParse(Console.ReadLine(), out int exponente) || exponente < 0)
            {
                Console.WriteLine("Exponente no válido. Debe ser un entero mayor o igual a 0.");
                return;
            }

            double resIterativo = PotenciaIterativa(baseNum, exponente);
            double resRecursivo = PotenciaRecursiva(baseNum, exponente);

            Console.WriteLine($"
Resultado (Iterativo): {baseNum}^{exponente} = {resIterativo}");
            Console.WriteLine($"Resultado (Recursivo): {baseNum}^{exponente} = {resRecursivo}");
        }

        /// <summary>
        /// Calcula la potencia de forma iterativa.
        /// </summary>
        static double PotenciaIterativa(double baseNum, int exponente)
        {
            double resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado *= baseNum;
            }
            return resultado;
        }

        /// <summary>
        /// Calcula la potencia de forma recursiva.
        /// </summary>
        static double PotenciaRecursiva(double baseNum, int exponente)
        {
            if (exponente == 0)
                return 1;
            return baseNum * PotenciaRecursiva(baseNum, exponente - 1);
        }
    }
}
