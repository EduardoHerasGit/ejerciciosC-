using System;
using System.Text;

namespace Ejercicio10
{
    // Ejercicio 10: Delegados y manejo de errores
    internal class Program
    {
        // Acepta un número y devuelve un número
        delegate double Calculo(double numero);

        // Raíz cuadrada: no está definida para números negativos
        static double RaizCuadrada(double numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");
            }

            return Math.Sqrt(numero);
        }

        // Logaritmo (neperiano): solo está definido para números mayores que cero
        static double Logaritmo(double numero)
        {
            if (numero <= 0)
            {
                throw new ArgumentException("No se puede calcular el logaritmo de un número menor o igual que cero.");
            }

            return Math.Log(numero);
        }

        // Recibe un delegado y un número, controla las posibles excepciones
        // e imprime el resultado o un mensaje de error
        static void EjecutarCalculo(Calculo calculo, double numero)
        {
            try
            {
                double resultado = calculo(numero);
                Console.WriteLine($"{calculo.Method.Name}({numero}) = {resultado}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"{calculo.Method.Name}({numero}) -> Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{calculo.Method.Name}({numero}) -> Error inesperado: {ex.Message}");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double[] numeros = { 16, 100, -4, 0 };

            foreach (double numero in numeros)
            {
                EjecutarCalculo(RaizCuadrada, numero);
                EjecutarCalculo(Logaritmo, numero);
                Console.WriteLine();
            }
        }
    }
}
