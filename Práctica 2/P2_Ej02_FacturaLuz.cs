using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("es-ES");

        // Precios según el enunciado (más de 1800 kW: 0,8; entre 1000 y 1800: 0,12; menos de 1000: 0,14)
        const decimal PRECIO_MAS_1800 = 0.8m;
        const decimal PRECIO_1000_1800 = 0.12m;
        const decimal PRECIO_MENOS_1000 = 0.14m;

        Console.Write("Introduce los kilowatios consumidos en el período anterior: ");
        decimal kw = decimal.Parse(Console.ReadLine());

        decimal precioKw;
        if (kw > 1800)
        {
            precioKw = PRECIO_MAS_1800;
        }
        else if (kw >= 1000)
        {
            precioKw = PRECIO_1000_1800;
        }
        else
        {
            precioKw = PRECIO_MENOS_1000;
        }

        decimal total = kw * precioKw;
        Console.WriteLine($"Total a pagar: {total:C2}");
    }
}
