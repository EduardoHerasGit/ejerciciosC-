using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("es-ES");

        double suma = 0;
        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"Introduce el valor {i}: ");
            suma += double.Parse(Console.ReadLine());
        }

        double promedio = suma / 4;
        Console.WriteLine($"La suma es {suma}");
        Console.WriteLine($"El promedio es {promedio}");
    }
}
