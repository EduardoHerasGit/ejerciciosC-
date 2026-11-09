using System;
using System.Globalization;

class Program
{
    // Precios fijados mediante constantes
    const decimal PRECIO_HAMBURGUESA = 3.50m;
    const decimal PRECIO_PAPAS = 1.75m;
    const decimal PRECIO_BEBIDA = 2.30m;

    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("es-ES");

        Console.Write("Cantidad de hamburguesas: ");
        int hamburguesas = int.Parse(Console.ReadLine());
        Console.Write("Cantidad de papas: ");
        int papas = int.Parse(Console.ReadLine());
        Console.Write("Cantidad de bebidas: ");
        int bebidas = int.Parse(Console.ReadLine());

        decimal total = hamburguesas * PRECIO_HAMBURGUESA
                      + papas * PRECIO_PAPAS
                      + bebidas * PRECIO_BEBIDA;

        Console.WriteLine($"Cantidad a pagar: {total:F2}€");
    }
}
