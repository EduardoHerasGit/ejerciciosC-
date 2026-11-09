using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un texto: ");
        string texto = Console.ReadLine();

        bool comienzaPorWww = texto.StartsWith("www");
        Console.WriteLine(comienzaPorWww);
    }
}
