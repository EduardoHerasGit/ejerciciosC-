using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("es-ES");

        double[] n = new double[4];
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Introduce el número {i + 1}: ");
            n[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"La suma de los dos primeros es {n[0] + n[1]}");
        Console.WriteLine($"El producto del tercero y el cuarto es {n[2] * n[3]}");
    }
}
