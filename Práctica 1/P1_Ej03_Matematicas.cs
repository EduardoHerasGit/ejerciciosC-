using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("es-ES");

        Console.Write("Introduce un número: ");
        double numero = double.Parse(Console.ReadLine());

        // Para las funciones que necesitan dos números, creamos el segundo por código
        double otroNumero = 10;

        Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
        Console.WriteLine($"Potencia al cubo: {Math.Pow(numero, 3)}");
        if (numero >= 0)
        {
            Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero)}");
        }
        else
        {
            Console.WriteLine("Raíz cuadrada: no existe para números negativos");
        }
        Console.WriteLine($"Seno: {Math.Sin(numero)}");
        Console.WriteLine($"Coseno: {Math.Cos(numero)}");
        Console.WriteLine($"Número máximo entre {numero} y {otroNumero}: {Math.Max(numero, otroNumero)}");
        Console.WriteLine($"Número mínimo entre {numero} y {otroNumero}: {Math.Min(numero, otroNumero)}");
    }
}
