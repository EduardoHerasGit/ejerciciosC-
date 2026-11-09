using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("es-ES");

        Console.Write("Introduce el valor de un lado del cuadrado: ");
        double lado = double.Parse(Console.ReadLine());

        double perimetro = 4 * lado;
        Console.WriteLine($"El perímetro del cuadrado es {perimetro}");
    }
}
