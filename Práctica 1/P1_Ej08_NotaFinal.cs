using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("es-ES");

        Console.Write("Nota del primer parcial: ");
        double parcial1 = double.Parse(Console.ReadLine());
        Console.Write("Nota del segundo parcial: ");
        double parcial2 = double.Parse(Console.ReadLine());
        Console.Write("Nota del examen: ");
        double examen = double.Parse(Console.ReadLine());
        Console.Write("Nota del trabajo final: ");
        double trabajo = double.Parse(Console.ReadLine());

        double promedioParciales = (parcial1 + parcial2) / 2;
        double notaFinal = promedioParciales * 0.5 + examen * 0.3 + trabajo * 0.2;

        Console.WriteLine($"Tu nota final en Desarrollo de Interfaces es {notaFinal:F2}");
    }
}
