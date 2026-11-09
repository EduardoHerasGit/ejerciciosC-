using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("es-ES");

        Console.Write("Introduce el precio del artículo: ");
        decimal precio = decimal.Parse(Console.ReadLine());
        Console.Write("Introduce la cantidad que lleva el cliente: ");
        int cantidad = int.Parse(Console.ReadLine());

        decimal total = precio * cantidad;
        Console.WriteLine($"El coste total es {total:F2}€");
    }
}
